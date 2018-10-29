using ParkingWFP.Model;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View.Vehicles
{
    public partial class VehicleModelCrud : Form
    {
        VehicleModel vehicleModel = new VehicleModel();
        public VehicleModelCrud()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {
            grid_vehicleModels.AutoGenerateColumns = false;
            grid_vehicleModels.DataSource = vehicleModel.LoadVehicleModelsToList();
        }

        private void Clear()
        {
            tbx_model.Text = "";

            btn_remove.Enabled = false;
            btn_save.Text = "Adicionar";

            vehicleModel.IdVehicleModel = 0;

            PopulateGrid();
        }

        private void VehicleModelCrud_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_clearForm_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool isValidModel()
        {
            var model = tbx_model.Text.Trim();

            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show($"Modelo é um campo obrigatório");
                return false;
            }

            if (vehicleModel.IdVehicleModel == 0 && vehicleModel.ExistsVehicleModel(model))
            {
                MessageBox.Show($"O Modelo já existe no banco de dados ");
                return false;
            }

            return true;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string msg = "Tem certeza que deseja remover esse Modelo?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (vehicleModel.RemoveVehicleModel(vehicleModel))
                {
                    Clear();
                    MessageBox.Show("Operação concluida");
                }
                else
                    MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isValidModel() == false)
                return;

            vehicleModel.Model = tbx_model.Text.Trim();
            vehicleModel.CreatedAt = vehicleModel.IdVehicleModel == 0 ? DateTime.Now : vehicleModel.CreatedAt;
            vehicleModel.UpdatedAt = DateTime.Now;

            bool completed = false;
            if (vehicleModel.IdVehicleModel == 0)
                completed = vehicleModel.InsertVehicleModel(vehicleModel);
            else
                completed = vehicleModel.UpdateVehicleModel(vehicleModel);

            if (completed)
            {
                Clear();
                MessageBox.Show("Operação concluida");
            }
            else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");

        }

        private void grid_vehicleModels_DoubleClick(object sender, EventArgs e)
        {
            if (grid_vehicleModels.CurrentRow.Index == -1)
                return;

            vehicleModel.IdVehicleModel = Convert.ToInt32(grid_vehicleModels.CurrentRow.Cells["IdVehicleModel"].Value);
            vehicleModel = vehicleModel.LoadVehicleModelById(vehicleModel.IdVehicleModel);

            tbx_model.Text = vehicleModel.Model;

            btn_save.Text = "Atualizar";
            btn_remove.Enabled = true;
        }
    }
}
