/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Control;
using ParkingWFP.Model;
using ParkingWFP.View.Access;
using ParkingWFP.View.Vehicles;
using System;
using System.ComponentModel;
using System.Linq;
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

        public User user = new User();

        public Dashboard()
        {
            InitializeComponent();
        }

        // START PARKING FORM ------------------------------------------------------------

        private void PopulateModelsCombobox()
        {
            cbx_models.DataSource = vehicleModel.LoadVehicleModelsToList();
            cbx_models.DisplayMember = "Model";
            cbx_models.ValueMember = "IdVehicleModel";
            cbx_models.SelectedIndex = 1;
        }

        private void PopulateCategoriesCombobox()
        {
            cbx_categories.DataSource = vehicleCategory.LoadCategoriesToList();
            cbx_categories.DisplayMember = "Category";
            cbx_categories.ValueMember = "IdVehicleCategory";
            cbx_categories.SelectedValue = 1;
        }

        private void PopulateColorsCombobox()
        {
            cbx_colors.DataSource = vehicleColor.LoadColorsToList();
            cbx_colors.DisplayMember = "Color";
            cbx_colors.ValueMember = "IdVehicleColor";
            cbx_colors.SelectedValue = 1;
        }
        private void PopulateStartComboboxes()
        {
            PopulateModelsCombobox();
            PopulateCategoriesCombobox();
            PopulateColorsCombobox();
        }

        private void ClearStartParkingForm()
        {
            parking = new Parking();
            vehicleModel = new VehicleModel();
            vehicleCategory = new VehicleCategory();
            vehicleColor = new VehicleColor();

            tbx_plate.Text = "";
            tbx_plate.Focus();

            PopulateStartComboboxes();
            cbx_models.SelectedValue = 1;
            cbx_categories.SelectedValue = 1;
            cbx_colors.SelectedValue = 1;

            PopulateFinishComboboxes();
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
            try
            {
                var modelSelectedValue = Convert.ToInt32(cbx_models.SelectedValue);
                vehicleModel = vehicleModel.LoadVehicleModelById(modelSelectedValue);
                if (vehicleModel != null)
                {
                    cbx_categories.SelectedValue = vehicleModel.CategorySuggestion;
                }
            } catch
            {
                return;
            }
        }

        // GENERAL DASHBOARD ------------------------------------------------------------

        void ApplyRowColors(int row)
        {
            var status = grid_parking.Rows[row].Cells["Status"].Value.ToString();

            switch (status)
            {
                case "EM ABERTO":
                    grid_parking.Rows[row].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case "FINALIZADO":
                    grid_parking.Rows[row].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    break;
                case "DESISTENCIA":
                    grid_parking.Rows[row].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                    break;
                default:
                    break;
            }
        }

        void SetRowParkingCategoryModelColor( int row)
        {

            string Code = grid_parking.Rows[row].Cells["Code"].Value.ToString();
            Parking current = parking.LoadParkingByCode(Code);

            grid_parking.Rows[row].Cells["Color"].Value = vehicleColor.LoadColorById(current.VehicleColor).Color;
            grid_parking.Rows[row].Cells["Category"].Value = vehicleCategory.LoadCategoryById(current.VehicleCategory).Category;
            grid_parking.Rows[row].Cells["Model"].Value = vehicleModel.LoadVehicleModelById(current.VehicleModel).Model;

        }
        private void PopulateGrid()
        {
            try
            {
                grid_parking.AutoGenerateColumns = false;
                grid_parking.DataSource = parking.FilterParking(tbx_filter.Text.Trim());

                
                for (int row = 0; row < grid_parking.Rows.Count; row++)
                {
                    ApplyRowColors(row);
                    SetRowParkingCategoryModelColor(row);
                }
            }
            catch (Exception e)
            {
                return;
            }
        }

        private void Clear()
        {
            parking = new Parking();
            ClearStartParkingForm();
            ClearFinishParkingForm();
            PopulateGrid();
        }

        // FINISH PARKING FORM ------------------------------------------------------------

        private void PopulateFinishComboboxes()
        {
            parking = new Parking();
            vehicleModel = new VehicleModel();
            vehicleCategory = new VehicleCategory();
            vehicleColor = new VehicleColor();

            var parkinkList = parking.LoadParkingsToList();
            cbx_plate.DataSource = parkinkList;
            cbx_plate.DisplayMember = "Plate";
            cbx_plate.ValueMember = "Plate";
            cbx_plate.SelectedValue = -1;
        }

        private void ClearFinishParkingForm()
        {
            PopulateFinishComboboxes();

            parking.IdParking = 0;
            parking.Plate = "";
            cbx_plate.SelectedValue = -1;


            vehicleModel.IdVehicleModel = 1;
            tbx_ModelDescription.Text = "";

            vehicleCategory.IdVehicleCategory = 1;
            tbx_categoryDescription.Text = "";

            vehicleColor.IdVehicleColor = 1;
            tbx_colorDescription.Text = "";

            btn_finishParking.Enabled = true;
            btn_cancelParking.Text = "Desistência";
        }

        // --------------------------------------------------------------------------------------------

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
            using ( var loginForm = new AdminLogin())
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

        public string RandomAlfanumeric()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 4)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            if (parking.ExistsParkingCode(result)) {
                return RandomAlfanumeric();
            } else {
                return result;
            }
        }

        private void btn_startParking_Click(object sender, EventArgs e)
        {
            if (isValidParking() == false)
            {
                return;
            }

            parking.Code = RandomAlfanumeric();
            parking.Plate = tbx_plate.Text.Trim();
            parking.VehicleModel = Convert.ToInt32(cbx_models.SelectedValue);
            parking.VehicleCategory = Convert.ToInt32(cbx_categories.SelectedValue);
            parking.VehicleColor = Convert.ToInt32(cbx_colors.SelectedValue);
            parking.StartedAt = DateTime.Now;
            parking.TotalValue = 0.0;
            parking.CanceledAt = default(DateTime);
            parking.FinalizedAt = default(DateTime);
            parking.Status = "EM ABERTO";
            parking.RegisteredBy = user.IdUser;

            bool completed = parking.InsertParking(parking);

            if (completed)
            {
                var category = vehicleCategory.LoadCategoryById(parking.VehicleCategory).Category;
                var color = vehicleColor.LoadColorById(parking.VehicleColor).Color;
                var model = vehicleModel.LoadVehicleModelById(parking.VehicleModel).Model;
                printerControl.PrintStartParking(parking, category, color, model);
                ClearStartParkingForm();
                PopulateGrid();
                tbx_plate.Focus();
            }
            else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
        }

        private void grid_parking_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid_parking.CurrentRow.Index == -1)
                    return;

                string Plate = grid_parking.CurrentRow.Cells["Plate"].Value.ToString();
                cbx_plate.SelectedValue = Plate;
                LoadParkingByPlateToFinishForm(Plate);
            } catch
            {
                return;
            }
        }


        private void LoadParkingByPlateToFinishForm(string plate)
        {
            parking = parking.LoadParkingByPlate(plate);
            if (parking.Status == "DESISTENCIA" || parking.Status == "FINALIZADO")
            {
                btn_finishParking.Enabled = false;
                btn_cancelParking.Text = "Retorno";
            } else
            {
                btn_finishParking.Enabled = true;
                btn_cancelParking.Text = "Desistência";
            }
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
                parking.FinalizedAt = default(DateTime);
                parking.CanceledAt = DateTime.Now;
                parking.Status = "DESISTENCIA";
                parking.RegisteredBy = user.IdUser;
                parking.TotalValue = 0.0;

                if (parking.UpdateParking(parking))
                {
                    MessageBox.Show("Operação concluida");
                    ClearFinishParkingForm();
                    PopulateGrid();
                    cbx_plate.Focus();
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
                parking.Status = "EM ABERTO";
                parking.RegisteredBy = user.IdUser;
                parking.FinalizedAt = default(DateTime);
                parking.CanceledAt = default(DateTime);
                parking.TotalValue = 0.0;

                if (parking.UpdateParking(parking))
                {
                    MessageBox.Show("Operação concluida");
                    ClearFinishParkingForm();
                    PopulateGrid();
                    cbx_plate.Focus();
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

            if (parking.Status == "DESISTENCIA" || parking.Status == "FINALIZADO")
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
            parking.RegisteredBy = user.IdUser;
            parking.CanceledAt = default(DateTime);

            using (var finishForm = new FinishParking())
            {
                finishForm.parking = parking;
                finishForm.ShowDialog();
            }

            ClearFinishParkingForm();
            PopulateGrid();
            cbx_plate.Focus();
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
            if (parking.ExistsParkingStarted())
            {
                string msg = "Existem estacionamentos não finalizados, tem certeza que deseja excluir?";
                if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            bool admin = false;
            using (var loginForm = new AdminLogin())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
            }

            if (admin)
            {
                if (parking.TruncateParking())
                {
                    Clear();
                }
                else
                    MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
            }
        }

        private void btn_testPrinterConnection_Click(object sender, EventArgs e)
        {
            string status = printerControl.TestPrinterConnection();
            MessageBox.Show(status);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            bool admin = false;
            using (var loginForm = new AdminLogin())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
            }

            if (admin)
            {
                using (var reportForm = new Report())
                {
                    reportForm.ShowDialog();
                }
            }
        }

        private void tbx_filter_TextChanged(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void tbx_plate_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbx_plate.Text) == false)
            {
                if (parking.ExistsParkingPlate(tbx_plate.Text.Trim()))
                {
                    MessageBox.Show($"Placa já cadastrada");
                    tbx_plate.Focus();
                }
            }
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            printer = printer.LoadPrinter();
            printerControl.SetupPrinterModel();
            printerControl.SetupPrinterConnection();
            Clear();
        }

        private void btn_finishParking_Enter(object sender, EventArgs e)
        {
            btn_finishParking.BackColor = System.Drawing.Color.Red;
        }

        private void btn_finishParking_Leave(object sender, EventArgs e)
        {
            btn_finishParking.BackColor = System.Drawing.Color.FromArgb(0, 112, 204);
        }

        private void btn_cancelParking_Enter(object sender, EventArgs e)
        {
            btn_cancelParking.BackColor = System.Drawing.Color.Red;
        }

        private void btn_cancelParking_Leave(object sender, EventArgs e)
        {
            btn_cancelParking.BackColor = System.Drawing.Color.FromArgb(110, 170, 250);
        }

        private void btn_clearFinishForm_Enter(object sender, EventArgs e)
        {
            btn_clearFinishForm.BackColor = System.Drawing.Color.Red;
        }

        private void btn_clearFinishForm_Leave(object sender, EventArgs e)
        {
            btn_clearFinishForm.BackColor = System.Drawing.Color.FromArgb(110, 170, 250);
        }

        private void btn_startParking_Enter(object sender, EventArgs e)
        {
            btn_startParking.BackColor = System.Drawing.Color.Red;
        }

        private void btn_startParking_Leave(object sender, EventArgs e)
        {
            btn_startParking.BackColor = System.Drawing.Color.FromArgb(0, 112, 204);
        }

        private void btn_clearStartForm_Enter(object sender, EventArgs e)
        {
            btn_clearStartForm.BackColor = System.Drawing.Color.Red;
        }

        private void btn_clearStartForm_Leave(object sender, EventArgs e)
        {
            btn_clearStartForm.BackColor = System.Drawing.Color.FromArgb(110, 170, 250);
        }
    }
}
