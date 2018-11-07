namespace ParkingWFP.View.Vehicles
{
    partial class VehicleModelCrud
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
            this.btn_clearForm = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_model = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_model = new System.Windows.Forms.TextBox();
            this.panel_gridVehicleModels = new System.Windows.Forms.Panel();
            this.tbx_modelFilter = new System.Windows.Forms.TextBox();
            this.lbl_modelFilter = new System.Windows.Forms.Label();
            this.cbx_categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_vehicleModels = new System.Windows.Forms.DataGridView();
            this.IdVehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategorySuggestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_usersCrudLabels.SuspendLayout();
            this.panel_gridVehicleModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleModels)).BeginInit();
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
            this.panel_usersCrudLabels.Size = new System.Drawing.Size(513, 55);
            this.panel_usersCrudLabels.TabIndex = 44;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(29, 13);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(127, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Modelos";
            // 
            // btn_clearForm
            // 
            this.btn_clearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_clearForm.FlatAppearance.BorderSize = 0;
            this.btn_clearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearForm.Location = new System.Drawing.Point(32, 187);
            this.btn_clearForm.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btn_clearForm.Name = "btn_clearForm";
            this.btn_clearForm.Size = new System.Drawing.Size(145, 40);
            this.btn_clearForm.TabIndex = 5;
            this.btn_clearForm.Text = "Limpar";
            this.btn_clearForm.UseVisualStyleBackColor = false;
            this.btn_clearForm.Click += new System.EventHandler(this.btn_clearForm_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(186, 187);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(145, 40);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(28, 29);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(81, 23);
            this.lbl_model.TabIndex = 56;
            this.lbl_model.Text = "Modelo:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(340, 187);
            this.btn_save.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 40);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Adicionar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_model
            // 
            this.tbx_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_model.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_model.Location = new System.Drawing.Point(32, 56);
            this.tbx_model.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_model.MaxLength = 200;
            this.tbx_model.Name = "tbx_model";
            this.tbx_model.Size = new System.Drawing.Size(450, 34);
            this.tbx_model.TabIndex = 1;
            // 
            // panel_gridVehicleModels
            // 
            this.panel_gridVehicleModels.AutoScroll = true;
            this.panel_gridVehicleModels.BackColor = System.Drawing.SystemColors.Control;
            this.panel_gridVehicleModels.Controls.Add(this.tbx_modelFilter);
            this.panel_gridVehicleModels.Controls.Add(this.lbl_modelFilter);
            this.panel_gridVehicleModels.Controls.Add(this.cbx_categories);
            this.panel_gridVehicleModels.Controls.Add(this.label1);
            this.panel_gridVehicleModels.Controls.Add(this.grid_vehicleModels);
            this.panel_gridVehicleModels.Controls.Add(this.btn_clearForm);
            this.panel_gridVehicleModels.Controls.Add(this.btn_save);
            this.panel_gridVehicleModels.Controls.Add(this.btn_remove);
            this.panel_gridVehicleModels.Controls.Add(this.tbx_model);
            this.panel_gridVehicleModels.Controls.Add(this.lbl_model);
            this.panel_gridVehicleModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_gridVehicleModels.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_gridVehicleModels.Location = new System.Drawing.Point(0, 55);
            this.panel_gridVehicleModels.Margin = new System.Windows.Forms.Padding(4);
            this.panel_gridVehicleModels.Name = "panel_gridVehicleModels";
            this.panel_gridVehicleModels.Padding = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.panel_gridVehicleModels.Size = new System.Drawing.Size(513, 583);
            this.panel_gridVehicleModels.TabIndex = 57;
            // 
            // tbx_modelFilter
            // 
            this.tbx_modelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_modelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_modelFilter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_modelFilter.Location = new System.Drawing.Point(35, 314);
            this.tbx_modelFilter.Margin = new System.Windows.Forms.Padding(38, 6, 6, 6);
            this.tbx_modelFilter.MaxLength = 200;
            this.tbx_modelFilter.Name = "tbx_modelFilter";
            this.tbx_modelFilter.Size = new System.Drawing.Size(447, 34);
            this.tbx_modelFilter.TabIndex = 6;
            this.tbx_modelFilter.TextChanged += new System.EventHandler(this.tbx_modelFilter_TextChanged);
            this.tbx_modelFilter.Enter += new System.EventHandler(this.tbx_modelFilter_Enter);
            // 
            // lbl_modelFilter
            // 
            this.lbl_modelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_modelFilter.AutoSize = true;
            this.lbl_modelFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelFilter.Location = new System.Drawing.Point(33, 285);
            this.lbl_modelFilter.Margin = new System.Windows.Forms.Padding(6, 29, 6, 0);
            this.lbl_modelFilter.Name = "lbl_modelFilter";
            this.lbl_modelFilter.Size = new System.Drawing.Size(138, 23);
            this.lbl_modelFilter.TabIndex = 61;
            this.lbl_modelFilter.Text = "Filtrar Modelo:";
            // 
            // cbx_categories
            // 
            this.cbx_categories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_categories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_categories.FormattingEnabled = true;
            this.cbx_categories.Location = new System.Drawing.Point(32, 123);
            this.cbx_categories.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_categories.Name = "cbx_categories";
            this.cbx_categories.Size = new System.Drawing.Size(450, 31);
            this.cbx_categories.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Categoria de Sugestão:";
            // 
            // grid_vehicleModels
            // 
            this.grid_vehicleModels.AllowUserToAddRows = false;
            this.grid_vehicleModels.AllowUserToDeleteRows = false;
            this.grid_vehicleModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_vehicleModels.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_vehicleModels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_vehicleModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vehicleModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehicleModel,
            this.Model,
            this.CategorySuggestion,
            this.CreatedAt,
            this.UpdatedAt});
            this.grid_vehicleModels.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_vehicleModels.Location = new System.Drawing.Point(32, 350);
            this.grid_vehicleModels.Margin = new System.Windows.Forms.Padding(28, 29, 28, 29);
            this.grid_vehicleModels.Name = "grid_vehicleModels";
            this.grid_vehicleModels.ReadOnly = true;
            this.grid_vehicleModels.RowTemplate.Height = 24;
            this.grid_vehicleModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_vehicleModels.Size = new System.Drawing.Size(453, 204);
            this.grid_vehicleModels.TabIndex = 7;
            this.grid_vehicleModels.Click += new System.EventHandler(this.grid_vehicleModels_Click);
            // 
            // IdVehicleModel
            // 
            this.IdVehicleModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdVehicleModel.DataPropertyName = "IdVehicleModel";
            this.IdVehicleModel.HeaderText = "Código";
            this.IdVehicleModel.Name = "IdVehicleModel";
            this.IdVehicleModel.ReadOnly = true;
            this.IdVehicleModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdVehicleModel.Visible = false;
            this.IdVehicleModel.Width = 78;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Modelo";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Model.Width = 300;
            // 
            // CategorySuggestion
            // 
            this.CategorySuggestion.DataPropertyName = "CategorySuggestion";
            this.CategorySuggestion.HeaderText = "Categoria de Sugestão";
            this.CategorySuggestion.Name = "CategorySuggestion";
            this.CategorySuggestion.ReadOnly = true;
            this.CategorySuggestion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CategorySuggestion.Visible = false;
            this.CategorySuggestion.Width = 250;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Data de Criação";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreatedAt.Visible = false;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Data de Atualização";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.ReadOnly = true;
            this.UpdatedAt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UpdatedAt.Visible = false;
            // 
            // VehicleModelCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 638);
            this.Controls.Add(this.panel_gridVehicleModels);
            this.Controls.Add(this.panel_usersCrudLabels);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleModelCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VehicleModelCrud_Load);
            this.panel_usersCrudLabels.ResumeLayout(false);
            this.panel_usersCrudLabels.PerformLayout();
            this.panel_gridVehicleModels.ResumeLayout(false);
            this.panel_gridVehicleModels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_usersCrudLabels;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clearForm;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_model;
        private System.Windows.Forms.Panel panel_gridVehicleModels;
        private System.Windows.Forms.DataGridView grid_vehicleModels;
        private System.Windows.Forms.ComboBox cbx_categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_modelFilter;
        private System.Windows.Forms.Label lbl_modelFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorySuggestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}