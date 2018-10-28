using ParkingWFP.Model;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View.Settings
{
    public partial class PrinterSettings : Form
    {
        public Printer printer = new Printer();
        public PrinterSettings()
        {
            InitializeComponent();
        }

        private void btn_updatePrinters_Click(object sender, EventArgs e)
        {
            printer.Model = txb_model.Text;
            printer.Host = txb_host.Text;
            printer.Port = txb_port.Text;
            printer.Header = txb_header.Text;
            printer.Footer = txb_footer.Text;
            printer.UpdatedAt = DateTime.Now;

            printer.UpdatePrinter(printer);
        }

        private void PrinterSettings_Load(object sender, EventArgs e)
        {
            printer = printer.LoadPrinter();
            if (printer != null)
            {
                txb_model.Text = printer.Model;
                txb_host.Text = printer.Host;
                txb_port.Text = printer.Port;
                txb_header.Text = printer.Header;
                txb_footer.Text = printer.Footer;
            }
            else
            {
                MessageBox.Show("ERRO: Não foi possível carregar as informações da Impressora");
            }
        }
    }
}
