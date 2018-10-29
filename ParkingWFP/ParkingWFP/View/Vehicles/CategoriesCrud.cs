/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Model;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View.Vehicles
{
    public partial class CategoriesCrud : Form
    {
        VehicleCategory category = new VehicleCategory();
 
        public CategoriesCrud()
        {
            InitializeComponent();
        }

        private void PopulateGrid()
        {
            grid_categories.AutoGenerateColumns = false;
            grid_categories.DataSource = category.LoadCategoriesToList();
        }

        private void Clear()
        {
            tbx_category.Text = "";
            tbx_value.Text = "";
            tbx_tolerance.Text = "";

            btn_remove.Enabled = false;
            btn_save.Text = "Adicionar";

            category.IdVehicleCategory = 0;

            PopulateGrid();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_clearForm_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool isValidCategory()
        {
            var categoryName = tbx_category.Text.Trim();
            var value = tbx_value.Text.Trim();
            var tolerance = tbx_tolerance.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show($"Categoria é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"Valor é um campo obrigatório");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tolerance))
            {
                MessageBox.Show($"Tolerância é um campo obrigatório");
                return false;
            }

            if (category.IdVehicleCategory == 0 && category.ExistsCategory(categoryName))
            {
                MessageBox.Show($"A Categoria já existe no banco de dados ");
                return false;
            }

            return true;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string msg = "Tem certeza que deseja remover essa categoria?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (category.RemoveCategory(category))
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
            if(isValidCategory() == false)
                return;

            category.Category = tbx_category.Text.Trim();
            category.Value = Convert.ToDouble(tbx_value.Text.Trim());
            category.Tolerance = Convert.ToInt32(tbx_tolerance.Text.Trim());
            category.CreatedAt = category.IdVehicleCategory == 0 ? DateTime.Now : category.CreatedAt;
            category.UpdatedAt = DateTime.Now;

            bool completed = false;
            if (category.IdVehicleCategory == 0)
                completed = category.InsertCategory(category);
            else
                completed = category.UpdateCategory(category);

            if (completed)
            {
                Clear();
                MessageBox.Show("Operação concluida");
            }
            else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
        }

        private void grid_categories_DoubleClick(object sender, EventArgs e)
        {
            if (grid_categories.CurrentRow.Index == -1)
                return;

            category.IdVehicleCategory = Convert.ToInt32(grid_categories.CurrentRow.Cells["IdVehicleCategory"].Value);
            category = category.LoadCategoryById(category.IdVehicleCategory);

            tbx_category.Text = category.Category;
            tbx_value.Text = category.Value.ToString();
            tbx_tolerance.Text = category.Tolerance.ToString();

            btn_save.Text = "Atualizar";
            btn_remove.Enabled = true;
        }

        private void tbx_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            int backspace = 8;
            int comman = 44;
            char key = e.KeyChar;

            if (key == comman && tbx_value.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(key) && key != backspace && key != comman)
                e.Handled = true;
        }

        private void tbx_tolerance_KeyPress(object sender, KeyPressEventArgs e)
        {
            int backspace = 8;
            char key = e.KeyChar;

            if (!char.IsDigit(key) && key != backspace)
                e.Handled = true;
        }
    }
}
