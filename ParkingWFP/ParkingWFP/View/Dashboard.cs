/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Control;
using ParkingWFP.Model;
using ParkingWFP.View.Access;
using ParkingWFP.View.Vehicles;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View
{
    public partial class Dashboard : Form
    {
        Parking parking = new Parking();

        Printer printer = new Printer();
        PrinterControl printerControl = new PrinterControl();

        VehicleModel vehicleModel = new VehicleModel();
        VehicleCategory vehicleCategory = new VehicleCategory();
        VehicleColor vehicleColor = new VehicleColor();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void PopulateModelsCombobox()
        {
            cbx_models.DataSource = vehicleModel.LoadVehicleModelsToList();
            cbx_models.DisplayMember = "Model";
            cbx_models.ValueMember = "IdVehicleModel";
            cbx_models.SelectedValue = -1;
        }

        private void PopulateCategoriesCombobox()
        {
            cbx_categories.DataSource = vehicleCategory.LoadCategoriesToList();
            cbx_categories.DisplayMember = "Category";
            cbx_categories.ValueMember = "IdVehicleCategory";
            cbx_categories.SelectedValue = -1;
        }

        private void PopulateColorsCombobox()
        {
            cbx_colors.DataSource = vehicleColor.LoadColorsToList();
            cbx_colors.DisplayMember = "Color";
            cbx_colors.ValueMember = "IdVehicleColor";
            cbx_colors.SelectedValue = -1;
        }
        private void PopulateStartComboboxes()
        {
            PopulateModelsCombobox();
            PopulateCategoriesCombobox();
            PopulateColorsCombobox();
        }

        private void PopulateFinishComboboxes()
        {
            parking.IdParking = 0;
            var parkinkList = parking.LoadNotFinishParkingsToList();
            cbx_plate.DataSource = parkinkList;
            cbx_plate.DisplayMember = "Plate";
            cbx_plate.ValueMember = "Plate";
            cbx_plate.SelectedValue = -1;

            cbx_parkingId.DataSource = parkinkList;
            cbx_parkingId.DisplayMember = "IdParking";
            cbx_parkingId.ValueMember = "IdParking";
            cbx_parkingId.SelectedValue = -1;
        }

        private void PopulateGrid()
        {
            grid_parking.AutoGenerateColumns = false;
            grid_parking.DataSource = parking.LoadParkingsToList();
        }

        private void ClearStartParkingForm()
        {
            parking.IdParking = 0;
            tbx_plate.Text = "";

            vehicleModel.IdVehicleModel = 0;
            cbx_models.SelectedValue = -1;

            vehicleCategory.IdVehicleCategory = 0;
            cbx_categories.SelectedValue = -1;

            vehicleColor.IdVehicleColor = 0;
            cbx_colors.SelectedValue = -1;

            PopulateGrid();
            PopulateFinishComboboxes();
        }

        private void ClearFinishParkingForm()
        {
            parking.IdParking = 0;
            parking.Plate = "";

            cbx_plate.SelectedValue = -1;
            cbx_parkingId.SelectedValue = -1;
            PopulateFinishComboboxes();

            tbx_ModelDescription.Text = "";
            tbx_categoryDescription.Text = "";
            tbx_colorDescription.Text = "";

            btn_finishParking.Enabled = true;
            btn_cancelParking.Text = "Desistência";

            PopulateGrid();
        }

        private void Clear()
        {
            ClearStartParkingForm();
            ClearFinishParkingForm();
        }


        private void TestPrinterConnection()
        {
            var status = printerControl.GetPrinterStatus();

            switch (status)
            {
                case 0:
                    MessageBox.Show("Não foi possível estabelecer a conexão");
                    break;
                case 5:
                    MessageBox.Show("Impressora com pouco papel");
                    break;
                case 9:
                    MessageBox.Show("Impressora com tampa aberta");
                    break;
                case 24:
                    MessageBox.Show("Conexão bem sucedida");
                    break;
                case 32:
                    MessageBox.Show("Impressora sem papel");
                    break;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            printer = printer.LoadPrinter();
            printerControl.SetupPrinterModel();
            printerControl.SetupPrinterConnection();

            PopulateStartComboboxes();
            PopulateFinishComboboxes();
            PopulateGrid();
            Clear();
        }

        private void btn_clearStartForm_Click(object sender, EventArgs e)
        {
            ClearStartParkingForm();
        }

        private void tbx_plate_TextChanged(object sender, EventArgs e)
        {
            parking.IdParking = 0;
        }

        private void cbx_models_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbx_models.SelectedValue;
            if (selected == null || selected.GetType() == typeof(VehicleModel))
            {
                return;
            }

            vehicleModel = vehicleModel.LoadVehicleModelById(Convert.ToInt32(selected));
            cbx_categories.SelectedValue = vehicleModel.CategorySuggestion;
        }

        private void btn_models_Click(object sender, EventArgs e)
        {
            using (var modelForm = new VehicleModelCrud())
            {
                modelForm.ShowDialog();
            }
            PopulateModelsCombobox();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            bool admin = false;
            using ( var loginForm = new Login())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
            }

            if (admin)
            {
                using (var categoriesForm = new CategoriesCrud())
                {
                    categoriesForm.ShowDialog();
                }
                PopulateCategoriesCombobox();
            }
        }

        private void btn_colors_Click(object sender, EventArgs e)
        {
            using (var colorsForm = new ColorsCrud())
            {
                colorsForm.ShowDialog();
            }
            PopulateStartComboboxes();
        }


        private bool isValidParking()
        {
            var plate = tbx_plate.Text.Trim();

            if (string.IsNullOrWhiteSpace(plate))
            {
                MessageBox.Show($"Placa é um campo obrigatório");
                return false;
            }
            if (parking.ExistsParkingPlate(plate))
            {
                MessageBox.Show($"Placa já cadastrada");
                return false;
            }

            if (Convert.ToInt32(cbx_models.SelectedValue) < 1)
            {
                MessageBox.Show($"Selecione um Modelo válido");
                return false;
            }

            if (Convert.ToInt32(cbx_categories.SelectedValue) < 1)
            {
                MessageBox.Show($"Selecione uma Categoria válida");
                return false;
            }

            if (Convert.ToInt32(cbx_colors.SelectedValue) < 1)
            {
                MessageBox.Show($"Selecione uma Cor válida");
                return false;
            }
            return true;

        }

        private void btn_startParking_Click(object sender, EventArgs e)
        {
            if (isValidParking() == false)
            {
                return;
            }

            parking.Plate = tbx_plate.Text.Trim();
            parking.VehicleModel = Convert.ToInt32(cbx_models.SelectedValue);
            parking.VehicleCategory = Convert.ToInt32(cbx_categories.SelectedValue);
            parking.VehicleColor = Convert.ToInt32(cbx_colors.SelectedValue);
            parking.StartedAt = DateTime.Now;
            parking.Status = "Em Aberto";

            bool completed = parking.InsertParking(parking);

            if (completed)
            {
                var category = vehicleCategory.LoadCategoryById(parking.VehicleCategory).Category;
                var color = vehicleColor.LoadColorById(parking.VehicleColor).Color;
                var model = vehicleModel.LoadVehicleModelById(parking.VehicleModel).Model;
                printerControl.PrintStartParking(parking, category, color, model);
                ClearStartParkingForm();

                MessageBox.Show("Operação concluída, imprimindo recibo");
            }
            else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
        }

        private void grid_parking_Click(object sender, EventArgs e)
        {
            if (grid_parking.CurrentRow.Index == -1)
                return;

            if (grid_parking.CurrentRow.Cells["Status"].Value.ToString() == "Finalizado")
            {
                return;
            }

            string Plate = grid_parking.CurrentRow.Cells["Plate"].Value.ToString();
            cbx_plate.SelectedValue = Plate;
            LoadParkingByPlateToFinishForm(Plate);
        }


        private void LoadParkingByPlateToFinishForm(string plate)
        {
            parking = parking.LoadParkingByPlate(plate);
            if (parking.Status == "Desistencia")
            {
                btn_finishParking.Enabled = false;
                btn_cancelParking.Text = "Retorno";
            } else
            {
                btn_finishParking.Enabled = true;
                btn_cancelParking.Text = "Desistência";
            }
            
            cbx_parkingId.SelectedValue = parking.IdParking;
            tbx_ModelDescription.Text = vehicleModel.LoadVehicleModelById(parking.VehicleModel).Model;
            tbx_categoryDescription.Text = vehicleCategory.LoadCategoryById(parking.VehicleCategory).Category;
            tbx_colorDescription.Text = vehicleColor.LoadColorById(parking.VehicleColor).Color;
        }

        private void cbx_plate_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = cbx_plate.SelectedValue;
            if (selected == null || selected.GetType() == typeof(Parking))
            {
                return;
            }

            LoadParkingByPlateToFinishForm(selected.ToString());
        }

        private void CancelParking()
        {
            string msg = "Tem certeza que deseja efetuar a desistência?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parking.CanceledAt = DateTime.Now;
                parking.Status = "Desistencia";

                if (parking.UpdateParking(parking))
                {
                    MessageBox.Show("Operação concluida");
                    ClearFinishParkingForm();
                    PopulateGrid();
                }
                else
                    MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
            }
        }

        private void RestartParking()
        {
            string msg = "Tem certeza que deseja efetuar o retorno?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parking.Status = "Em Aberto";

                if (parking.UpdateParking(parking))
                {
                    MessageBox.Show("Operação concluida");
                    ClearFinishParkingForm();
                    PopulateGrid();
                }
                else
                    MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
            }
        }
        private void btn_cancelParking_Click(object sender, EventArgs e)
        {
            try
            {
                parking = parking.LoadParkingByPlate(cbx_plate.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar a placa selecionada, tente novamente");
                return;
            }

            if (parking.Status == "Desistencia")
            {
                RestartParking();
            }
            else
            {
                CancelParking();
            }
        }

        private void btn_finishParking_Click(object sender, EventArgs e)
        {
            if(cbx_plate.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma placa ou comanda");
                return;
            }

            parking = parking.LoadParkingByPlate(cbx_plate.SelectedValue.ToString());
            using (var finishForm = new FinishParking())
            {
                finishForm.parking = parking;
                finishForm.ShowDialog();
            }

            ClearFinishParkingForm();
            PopulateGrid();
        }

        private void btn_clearFinishForm_Click(object sender, EventArgs e)
        {
            ClearFinishParkingForm();
        }

        private void btn_truncateParking_Click(object sender, EventArgs e)
        {
            if (grid_parking.Rows.Count == 0)
            {
                return;
            }
            if (parking.ExistsParkingStarted()) { 
                string msg = "Existem estacionamentos não finalizados, tem certeza que deseja excluir?";
                if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            bool admin = false;
            using (var loginForm = new Login())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
            }

            if (admin)
            {
                if (parking.TruncateParking())
                {
                    MessageBox.Show("Operação concluída");
                    Clear();
                }
                else
                    MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
            }
        }

        private void btn_testPrinterConnection_Click(object sender, EventArgs e)
        {
            TestPrinterConnection();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            using (var reportForm = new Report())
            {
                reportForm.ShowDialog();
            }
        }
    }
}
