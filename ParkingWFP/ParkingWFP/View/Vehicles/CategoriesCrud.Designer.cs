/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

namespace ParkingWFP.View.Vehicles
{
    partial class CategoriesCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_usersCrudLabels = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_categoriesCrudTextBoxes = new System.Windows.Forms.Panel();
            this.tbx_categoryFilter = new System.Windows.Forms.TextBox();
            this.lbl_categoryFilter = new System.Windows.Forms.Label();
            this.grid_categories = new System.Windows.Forms.DataGridView();
            this.IdVehicleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbx_value = new System.Windows.Forms.TextBox();
            this.btn_clearForm = new System.Windows.Forms.Button();
            this.lbl_value = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_category = new System.Windows.Forms.TextBox();
            this.tbx_tolerance = new System.Windows.Forms.TextBox();
            this.lbl_tolerance = new System.Windows.Forms.Label();
            this.panel_usersCrudLabels.SuspendLayout();
            this.panel_categoriesCrudTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_usersCrudLabels
            // 
            this.panel_usersCrudLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_usersCrudLabels.Controls.Add(this.lbl_title);
            this.panel_usersCrudLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_usersCrudLabels.Location = new System.Drawing.Point(0, 0);
            this.panel_usersCrudLabels.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usersCrudLabels.Name = "panel_usersCrudLabels";
            this.panel_usersCrudLabels.Padding = new System.Windows.Forms.Padding(28, 14, 0, 14);
            this.panel_usersCrudLabels.Size = new System.Drawing.Size(500, 55);
            this.panel_usersCrudLabels.TabIndex = 42;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(28, 14);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(158, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Categorias";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_categoriesCrudTextBoxes
            // 
            this.panel_categoriesCrudTextBoxes.AutoScroll = true;
            this.panel_categoriesCrudTextBoxes.BackColor = System.Drawing.SystemColors.Control;
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.tbx_categoryFilter);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.lbl_categoryFilter);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.grid_categories);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.tbx_value);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.btn_clearForm);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.lbl_value);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.btn_remove);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.lbl_categoryName);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.btn_save);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.tbx_category);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.tbx_tolerance);
            this.panel_categoriesCrudTextBoxes.Controls.Add(this.lbl_tolerance);
            this.panel_categoriesCrudTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_categoriesCrudTextBoxes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_categoriesCrudTextBoxes.Location = new System.Drawing.Point(0, 55);
            this.panel_categoriesCrudTextBoxes.Margin = new System.Windows.Forms.Padding(4);
            this.panel_categoriesCrudTextBoxes.Name = "panel_categoriesCrudTextBoxes";
            this.panel_categoriesCrudTextBoxes.Padding = new System.Windows.Forms.Padding(20);
            this.panel_categoriesCrudTextBoxes.Size = new System.Drawing.Size(500, 556);
            this.panel_categoriesCrudTextBoxes.TabIndex = 43;
            // 
            // tbx_categoryFilter
            // 
            this.tbx_categoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_categoryFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_categoryFilter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_categoryFilter.Location = new System.Drawing.Point(24, 274);
            this.tbx_categoryFilter.Margin = new System.Windows.Forms.Padding(38, 6, 6, 6);
            this.tbx_categoryFilter.MaxLength = 200;
            this.tbx_categoryFilter.Name = "tbx_categoryFilter";
            this.tbx_categoryFilter.Size = new System.Drawing.Size(447, 34);
            this.tbx_categoryFilter.TabIndex = 62;
            this.tbx_categoryFilter.TextChanged += new System.EventHandler(this.tbx_categoryFilter_TextChanged);
            this.tbx_categoryFilter.Enter += new System.EventHandler(this.tbx_categoryFilter_Enter);
            // 
            // lbl_categoryFilter
            // 
            this.lbl_categoryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_categoryFilter.AutoSize = true;
            this.lbl_categoryFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryFilter.Location = new System.Drawing.Point(20, 245);
            this.lbl_categoryFilter.Margin = new System.Windows.Forms.Padding(6, 29, 6, 0);
            this.lbl_categoryFilter.Name = "lbl_categoryFilter";
            this.lbl_categoryFilter.Size = new System.Drawing.Size(159, 23);
            this.lbl_categoryFilter.TabIndex = 63;
            this.lbl_categoryFilter.Text = "Filtrar Categoria:";
            // 
            // grid_categories
            // 
            this.grid_categories.AllowUserToAddRows = false;
            this.grid_categories.AllowUserToDeleteRows = false;
            this.grid_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_categories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_categories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehicleCategory,
            this.CategoryName,
            this.Value,
            this.Tolerance,
            this.CreatedAt,
            this.UpdatedAt});
            this.grid_categories.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_categories.Location = new System.Drawing.Point(24, 306);
            this.grid_categories.Margin = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.grid_categories.Name = "grid_categories";
            this.grid_categories.ReadOnly = true;
            this.grid_categories.RowTemplate.Height = 24;
            this.grid_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_categories.Size = new System.Drawing.Size(447, 229);
            this.grid_categories.TabIndex = 7;
            this.grid_categories.Click += new System.EventHandler(this.grid_categories_Click);
            // 
            // IdVehicleCategory
            // 
            this.IdVehicleCategory.DataPropertyName = "IdVehicleCategory";
            this.IdVehicleCategory.HeaderText = "Código";
            this.IdVehicleCategory.Name = "IdVehicleCategory";
            this.IdVehicleCategory.ReadOnly = true;
            this.IdVehicleCategory.Visible = false;
            this.IdVehicleCategory.Width = 80;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Category";
            this.CategoryName.HeaderText = "Categoria";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 210;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Valor";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 120;
            // 
            // Tolerance
            // 
            this.Tolerance.DataPropertyName = "Tolerance";
            this.Tolerance.HeaderText = "Tolerância";
            this.Tolerance.Name = "Tolerance";
            this.Tolerance.ReadOnly = true;
            this.Tolerance.Width = 120;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Data de Criação";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Visible = false;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Data de Atualização";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.Visible = false;
            // 
            // tbx_value
            // 
            this.tbx_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_value.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_value.Location = new System.Drawing.Point(24, 112);
            this.tbx_value.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_value.MaxLength = 8;
            this.tbx_value.Name = "tbx_value";
            this.tbx_value.Size = new System.Drawing.Size(207, 34);
            this.tbx_value.TabIndex = 2;
            this.tbx_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_value_KeyPress);
            // 
            // btn_clearForm
            // 
            this.btn_clearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_clearForm.FlatAppearance.BorderSize = 0;
            this.btn_clearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearForm.Location = new System.Drawing.Point(24, 163);
            this.btn_clearForm.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_clearForm.Name = "btn_clearForm";
            this.btn_clearForm.Size = new System.Drawing.Size(145, 40);
            this.btn_clearForm.TabIndex = 6;
            this.btn_clearForm.Text = "Limpar";
            this.btn_clearForm.UseVisualStyleBackColor = false;
            this.btn_clearForm.Click += new System.EventHandler(this.btn_clearForm_Click);
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(24, 85);
            this.lbl_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(61, 23);
            this.lbl_value.TabIndex = 24;
            this.lbl_value.Text = "Valor:";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(177, 163);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(145, 40);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryName.Location = new System.Drawing.Point(20, 20);
            this.lbl_categoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(102, 23);
            this.lbl_categoryName.TabIndex = 28;
            this.lbl_categoryName.Text = "Categoria:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(330, 163);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 40);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Atualizar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_category
            // 
            this.tbx_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_category.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_category.Location = new System.Drawing.Point(24, 47);
            this.tbx_category.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_category.MaxLength = 200;
            this.tbx_category.Name = "tbx_category";
            this.tbx_category.Size = new System.Drawing.Size(451, 34);
            this.tbx_category.TabIndex = 1;
            // 
            // tbx_tolerance
            // 
            this.tbx_tolerance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tolerance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tolerance.Location = new System.Drawing.Point(267, 112);
            this.tbx_tolerance.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_tolerance.MaxLength = 8;
            this.tbx_tolerance.Name = "tbx_tolerance";
            this.tbx_tolerance.Size = new System.Drawing.Size(207, 34);
            this.tbx_tolerance.TabIndex = 3;
            this.tbx_tolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_tolerance_KeyPress);
            // 
            // lbl_tolerance
            // 
            this.lbl_tolerance.AutoSize = true;
            this.lbl_tolerance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tolerance.Location = new System.Drawing.Point(263, 85);
            this.lbl_tolerance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tolerance.Name = "lbl_tolerance";
            this.lbl_tolerance.Size = new System.Drawing.Size(105, 23);
            this.lbl_tolerance.TabIndex = 30;
            this.lbl_tolerance.Text = "Tolerância:";
            // 
            // CategoriesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(500, 611);
            this.Controls.Add(this.panel_categoriesCrudTextBoxes);
            this.Controls.Add(this.panel_usersCrudLabels);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriesCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel_usersCrudLabels.ResumeLayout(false);
            this.panel_usersCrudLabels.PerformLayout();
            this.panel_categoriesCrudTextBoxes.ResumeLayout(false);
            this.panel_categoriesCrudTextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_usersCrudLabels;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_categoriesCrudTextBoxes;
        private System.Windows.Forms.TextBox tbx_value;
        private System.Windows.Forms.Button btn_clearForm;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_category;
        private System.Windows.Forms.TextBox tbx_tolerance;
        private System.Windows.Forms.Label lbl_tolerance;
        private System.Windows.Forms.DataGridView grid_categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehicleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tolerance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
        private System.Windows.Forms.TextBox tbx_categoryFilter;
        private System.Windows.Forms.Label lbl_categoryFilter;
    }
}