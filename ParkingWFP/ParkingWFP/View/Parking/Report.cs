/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Control;
using ParkingWFP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ParkingWFP.View
{
    public partial class Report : Form
    {
        User user = new User();
        PrinterControl printerControl = new PrinterControl();

        Parking parking = new Parking();
        List<Parking> parkingList = new List<Parking>();

        ReportDetail started = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0};
        ReportDetail finalized = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0, TotalValue = 0.0 };
        ReportDetail canceled = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0 };
        double discount = 0.0;
        double increase = 0.0;

        public Report()
        {
            InitializeComponent();

            LoadReport();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            var users = user.LoadUsersToList();

            cbx_reportedBy.Items.Add("TODOS");
            foreach (User item in users)
            {
                cbx_reportedBy.Items.Add(item.Username);
            }
        }

        private void LoadReport()
        {
            CalculateParkingReport();

            tbx_startedCategory1.Text = started.Category1.ToString();
            tbx_startedCategory2.Text = started.Category2.ToString();
            tbx_startedCategory3.Text = started.Category3.ToString();

            tbx_finalizedCategory1.Text = finalized.Category1.ToString();
            tbx_finalizedCategory2.Text = finalized.Category2.ToString();
            tbx_finalizedCategory3.Text = finalized.Category3.ToString();

            tbx_canceledCategory1.Text = canceled.Category1.ToString();
            tbx_canceledCategory2.Text = canceled.Category2.ToString();
            tbx_canceledCategory3.Text = canceled.Category3.ToString();

            tbx_totalVehicles.Text = parkingList.Count.ToString();
            tbx_TotalValue.Text = finalized.TotalValue.ToString();
            tbx_discount.Text = discount.ToString();
            tbx_increase.Text = increase.ToString();
        }

        private void CalculateParkingReport()
        {
            started = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0 };
            finalized = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0, TotalValue = 0.0 };
            canceled = new ReportDetail { Category1 = 0, Category2 = 0, Category3 = 0 };
            discount = 0.0;
            increase = 0.0;

            foreach (Parking item in parkingList)
            {
                switch (item.Status)
                {
                    case "EM ABERTO":
                        started = UpdateReportDetailCategories(started, item);
                        break;
                    case "FINALIZADO":
                        finalized = UpdateReportDetailCategories(finalized, item);
                        finalized.TotalValue = finalized.TotalValue + item.TotalValue;
                        discount = discount + item.Discount;
                        increase = increase + item.Increase;
                        break;
                    case "DESISTENCIA":
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
            var selected = cbx_reportedBy.SelectedValue;
            if (selected != null && selected.GetType() != typeof(User))
            {
                user = user.LoadUserById(Convert.ToInt32(selected));
            }
            else
            {
                user = user.LoadUserById(1);
            }

            string Report = "RESPONSÁVEL " + user.Username + "\n\n";

            Report += "VECÍCULOS NO ESTACIONAMENTO\n";
            Report += "CARRO " + started.Category1.ToString() + "\n";
            Report += "SUV/CAM " + started.Category2.ToString() + "\n";
            Report += "MOTO " + started.Category3.ToString() + "\n\n";

            Report += "VECÍCULOS FINALIZADOS\n";
            Report += "CARRO " + finalized.Category1.ToString() + "\n";
            Report += "SUV/CAM " + finalized.Category2.ToString() + "\n";
            Report += "MOTO " + finalized.Category3.ToString() + "\n\n";

            Report += "VEÍCULOS DESISTENTES\n";
            Report += "CARRO " + canceled.Category1.ToString() + "\n";
            Report += "SUV/CAM " + canceled.Category2.ToString() + "\n";
            Report += "MOTO " + canceled.Category3.ToString() + "\n\n";

            Report += "TOTAL VEÍCULOS " + parkingList.Count.ToString() + "\n\n";

            Report += "DESCONTOS R$:" + discount.ToString() + "\n";
            Report += "ACRESCIMOS R$:" + increase.ToString() + "\n\n";

            Report += "TOTAL EM CAIXA R$:" + finalized.TotalValue.ToString() + "\n\n";

            return Report;
        }
        private void btn_print_Click(object sender, System.EventArgs e)
        {
            string report = MountReport();

            printerControl.SetupPrinterModel();
            printerControl.SetupPrinterConnection();
            printerControl.PrintMultilineText(0, false, 0, 2, 0, 0, report);
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

        private void cbx_reportedBy_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = cbx_reportedBy.SelectedItem;
            try {
                var userSelected = user.LoadUserByUsername(selected.ToString());
                if (userSelected != null)
                {
                    parkingList = parking.LoadParkingsToListFilteredByRegisteredBy(userSelected.IdUser);
                } else
                {
                    parkingList = parking.LoadParkingsToList();
                    cbx_reportedBy.SelectedIndex = 0;
                }
            } catch
            {
                parkingList = parking.LoadParkingsToList();
                cbx_reportedBy.SelectedIndex = 0;
            }
            LoadReport();
        }
    }
}
