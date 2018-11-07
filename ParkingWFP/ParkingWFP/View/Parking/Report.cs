/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Control;
using ParkingWFP.Model;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ParkingWFP.View
{
    public partial class Report : Form
    {
        PrinterControl printerControl = new PrinterControl();

        Parking parking = new Parking();
        List<Parking> parkingList = new List<Parking>();

        ReportDetail started = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0};
        ReportDetail finalized = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0, TotalValue = 0.0 };
        ReportDetail canceled = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0 };

        public Report()
        {
            InitializeComponent();

            parkingList = parking.LoadParkingsToList();
        }

        private void Report_Load(object sender, System.EventArgs e)
        {
            CalculateParkingReport();

            tbx_startedCategory1.Text = started.Category1.ToString();
            tbx_startedCategory2.Text = started.Category2.ToString();
            tbx_startedCategory3.Text = started.Category3.ToString();

            tbx_finalizedCategory1.Text = finalized.Category1.ToString();
            tbx_finalizedCategory2.Text = finalized.Category2.ToString();
            tbx_finalizedCategory3.Text = finalized.Category3.ToString();

            tbx_caceledCategory1.Text = canceled.Category1.ToString();
            tbx_caceledCategory2.Text = canceled.Category2.ToString();
            tbx_caceledCategory3.Text = canceled.Category3.ToString();

            tbx_totalVehicles.Text = parkingList.Count.ToString();
            tbx_TotalValue.Text = finalized.TotalValue.ToString();
        }

        private void CalculateParkingReport()
        {
            foreach (Parking item in parkingList)
            {
                switch (item.Status)
                {
                    case "Em Aberto":
                        started = UpdateReportDetailCategories(started, item);
                        break;
                    case "Finalizado":
                        finalized = UpdateReportDetailCategories(finalized, item);
                        finalized.TotalValue = finalized.TotalValue + item.TotalValue;
                        break;
                    case "Desistencia":
                        canceled = UpdateReportDetailCategories(canceled, item);
                        break;
                    default:
                        break;
                }
            }
        }
        private ReportDetail UpdateReportDetailCategories(ReportDetail reportDetail, Parking parking)
        {
            switch (parking.VehicleCategory)
            {
                case 1:
                    ++reportDetail.Category1;
                    break;
                case 2:
                    ++reportDetail.Category2;
                    break;
                case 3:
                    ++reportDetail.Category3;
                    break;
                default:
                    break;
            }

            return reportDetail;
        }

        private string MountReport()
        {
            string Report = "VEÍCULOS NO ESTACIONAMENTO\n";
            Report += "C 1 - " + started.Category1.ToString() + "\n";
            Report += "C 2 - " + started.Category2.ToString() + "\n";
            Report += "C 3 - " + started.Category3.ToString() + "\n\n";

            Report += "VECÍCULOS FINALIZADOS\n";
            Report += "C 1 - " + finalized.Category1.ToString() + "\n";
            Report += "C 2 - " + finalized.Category2.ToString() + "\n";
            Report += "C 3 - " + finalized.Category3.ToString() + "\n\n";

            Report += "VEÍCULOS DESISTENTES\n";
            Report += "C 1 - " + canceled.Category1.ToString() + "\n";
            Report += "C 2 - " + canceled.Category2.ToString() + "\n";
            Report += "C 3 - " + canceled.Category3.ToString() + "\n\n";

            Report += "TOTAL VEÍCULOS - " + parkingList.Count.ToString() + "\n";
            Report += "TOTAL CAIXA - " + finalized.TotalValue.ToString() + "\n\n";

            return Report;
        }
        private void btn_print_Click(object sender, System.EventArgs e)
        {
            string Report = MountReport();
            printerControl.PrintMultilineText(0, false, 0, 2, 0, 0, Report);
            printerControl.CutPaper();
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo texto | *.txt";
            saveFileDialog.ShowDialog();

            string [] Report = MountReport().Split('\n');

            if (string.IsNullOrWhiteSpace(saveFileDialog.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        foreach(string line in Report)
                        {
                            writer.WriteLine(line);
                        }
                        writer.Flush();
                    }
                }
                catch (System.Exception)
                {

                    MessageBox.Show(
                        "Não foi possível Salvar o arquivo",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
