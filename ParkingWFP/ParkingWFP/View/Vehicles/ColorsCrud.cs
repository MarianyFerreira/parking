using System;
using System.Windows.Forms;

namespace ParkingWFP.View.Vehicles
{
    public partial class ColorsCrud : Form
    {
        Model.VehicleColor vehicleColor = new Model.VehicleColor();

        public ColorsCrud()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {
            grid_vehicleColors.AutoGenerateColumns = false;
            grid_vehicleColors.DataSource = vehicleColor.LoadColorsToList();
        }

        private void Clear()
        {
            tbx_color.Text = "";

            btn_remove.Enabled = false;
            btn_save.Text = "Adicionar";

            vehicleColor.IdVehicleColor = 0;

            PopulateGrid();
        }

        private void ColorsCrud_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_clearForm_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool isValidColor()
        {
            var vehicleColorName = tbx_color.Text.Trim();

            if (string.IsNullOrWhiteSpace(vehicleColorName))
            {
                MessageBox.Show($"Cor é um campo obrigatório");
                return false;
            }

            if (vehicleColor.IdVehicleColor == 0 && vehicleColor.ExistsColor(vehicleColorName))
            {
                MessageBox.Show($"A Cor já existe no banco de dados ");
                return false;
            }

            return true;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string msg = "Tem certeza que deseja remover essa cor?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (vehicleColor.RemoveColor(vehicleColor))
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
            if (isValidColor() == false)
                return;

            vehicleColor.Color = tbx_color.Text.Trim();
            vehicleColor.CreatedAt = vehicleColor.IdVehicleColor == 0 ? DateTime.Now : vehicleColor.CreatedAt;
            vehicleColor.UpdatedAt = DateTime.Now;

            bool completed = false;
            if (vehicleColor.IdVehicleColor == 0)
                completed = vehicleColor.InsertColor(vehicleColor);
            else
                completed = vehicleColor.UpdateColor(vehicleColor);

            if (completed)
            {
                Clear();
                MessageBox.Show("Operação concluida");
            }
            else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");

        }

        private void grid_vehicleColors_DoubleClick(object sender, EventArgs e)
        {
            if (grid_vehicleColors.CurrentRow.Index == -1)
                return;

            vehicleColor.IdVehicleColor = Convert.ToInt32(grid_vehicleColors.CurrentRow.Cells["IdVehicleColor"].Value);
            vehicleColor = vehicleColor.LoadColorById(vehicleColor.IdVehicleColor);

            tbx_color.Text = vehicleColor.Color;

            btn_save.Text = "Atualizar";
            btn_remove.Enabled = true;
        }
    }
}
