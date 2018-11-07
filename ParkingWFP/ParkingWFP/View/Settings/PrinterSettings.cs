using ParkingWFP.Control;
using ParkingWFP.Model;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View.Settings
{
    public partial class PrinterSettings : Form
    {
        public Printer printer = new Printer();
        PrinterControl printerControl = new PrinterControl();

        public PrinterSettings()
        {
            InitializeComponent();
        }

        private void PrinterSettings_Load(object sender, EventArgs e)
        {
            printer = printer.LoadPrinter();
            if (printer != null)
            {
                txb_header.Text = printer.Header;
                txb_footer.Text = printer.Footer;
            }
            else
            {
                MessageBox.Show("ERRO: Não foi possível carregar as informações da Impressora");
            }
        }

        private void btn_updatePrinters_Click(object sender, EventArgs e)
        {
            printer.Header = txb_header.Text.Trim();
            printer.Footer = txb_footer.Text.Trim();
            printer.UpdatedAt = DateTime.Now;

            bool complete = printer.UpdatePrinter(printer);

            if (complete)
            {
                MessageBox.Show($"Impressora atualizada");
            } else
            {
                MessageBox.Show($"ERRO: Não foi possível atualizar os dados da Impressora");
            }
        }

        private void txb_model_KeyPress(object sender, KeyPressEventArgs e)
        {
            int backspace = 8;
            char key = e.KeyChar;

            if (!char.IsDigit(key) && key != backspace)
                e.Handled = true;
        }

        private void btn_testPrinter_Click(object sender, EventArgs e)
        {
            printerControl.SetupPrinterModel();
            printerControl.SetupPrinterConnection();

            printerControl.PrintText(
                printer.Bold,
                printer.Expanded,
                printer.Font,
                printer.Italic,
                printer.Underline,
                "Teste de Impressão" 
            );

            printerControl.CutPaper();
        }

        private void btn_testPrinterConnection_Click(object sender, EventArgs e)
        {
            string status = printerControl.TestPrinterConnection();
            MessageBox.Show(status);
        }

    }
}
