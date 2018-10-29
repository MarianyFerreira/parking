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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_clearForm = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_model = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_model = new System.Windows.Forms.TextBox();
            this.panel_gridVehicleModels = new System.Windows.Forms.Panel();
            this.grid_vehicleModels = new System.Windows.Forms.DataGridView();
            this.IdVehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_usersCrudLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_gridVehicleModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleModels)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_usersCrudLabels
            // 
            this.panel_usersCrudLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_usersCrudLabels.Controls.Add(this.pictureBox1);
            this.panel_usersCrudLabels.Controls.Add(this.lbl_title);
            this.panel_usersCrudLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_usersCrudLabels.Location = new System.Drawing.Point(0, 0);
            this.panel_usersCrudLabels.Name = "panel_usersCrudLabels";
            this.panel_usersCrudLabels.Size = new System.Drawing.Size(800, 50);
            this.panel_usersCrudLabels.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingWFP.Properties.Resources.vehicle__2_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(60, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(127, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Modelos";
            // 
            // btn_clearForm
            // 
            this.btn_clearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_clearForm.FlatAppearance.BorderSize = 0;
            this.btn_clearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearForm.Location = new System.Drawing.Point(219, 146);
            this.btn_clearForm.Name = "btn_clearForm";
            this.btn_clearForm.Size = new System.Drawing.Size(130, 40);
            this.btn_clearForm.TabIndex = 55;
            this.btn_clearForm.Text = "Limpar";
            this.btn_clearForm.UseVisualStyleBackColor = false;
            this.btn_clearForm.Click += new System.EventHandler(this.btn_clearForm_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(355, 146);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(130, 40);
            this.btn_remove.TabIndex = 54;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(62, 82);
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
            this.btn_save.Location = new System.Drawing.Point(491, 146);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 40);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "Adicionar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_model
            // 
            this.tbx_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_model.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_model.Location = new System.Drawing.Point(161, 80);
            this.tbx_model.MaxLength = 200;
            this.tbx_model.Name = "tbx_model";
            this.tbx_model.Size = new System.Drawing.Size(460, 27);
            this.tbx_model.TabIndex = 52;
            // 
            // panel_gridVehicleModels
            // 
            this.panel_gridVehicleModels.Controls.Add(this.grid_vehicleModels);
            this.panel_gridVehicleModels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_gridVehicleModels.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_gridVehicleModels.Location = new System.Drawing.Point(0, 192);
            this.panel_gridVehicleModels.Name = "panel_gridVehicleModels";
            this.panel_gridVehicleModels.Size = new System.Drawing.Size(800, 258);
            this.panel_gridVehicleModels.TabIndex = 57;
            // 
            // grid_vehicleModels
            // 
            this.grid_vehicleModels.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_vehicleModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vehicleModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehicleModel,
            this.Model,
            this.CreatedAt,
            this.UpdatedAt});
            this.grid_vehicleModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_vehicleModels.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_vehicleModels.Location = new System.Drawing.Point(0, 0);
            this.grid_vehicleModels.Name = "grid_vehicleModels";
            this.grid_vehicleModels.RowTemplate.Height = 24;
            this.grid_vehicleModels.Size = new System.Drawing.Size(800, 258);
            this.grid_vehicleModels.TabIndex = 0;
            this.grid_vehicleModels.DoubleClick += new System.EventHandler(this.grid_vehicleModels_DoubleClick);
            // 
            // IdVehicleModel
            // 
            this.IdVehicleModel.DataPropertyName = "IdVehicleModel";
            this.IdVehicleModel.HeaderText = "Código";
            this.IdVehicleModel.Name = "IdVehicleModel";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Modelo";
            this.Model.Name = "Model";
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Data de Criação";
            this.CreatedAt.Name = "CreatedAt";
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Data de Atualização";
            this.UpdatedAt.Name = "UpdatedAt";
            // 
            // VehicleModelCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_gridVehicleModels);
            this.Controls.Add(this.btn_clearForm);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbx_model);
            this.Controls.Add(this.panel_usersCrudLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleModelCrud";
            this.Text = "VehicleModelCrud";
            this.Load += new System.EventHandler(this.VehicleModelCrud_Load);
            this.panel_usersCrudLabels.ResumeLayout(false);
            this.panel_usersCrudLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_gridVehicleModels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_usersCrudLabels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clearForm;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_model;
        private System.Windows.Forms.Panel panel_gridVehicleModels;
        private System.Windows.Forms.DataGridView grid_vehicleModels;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}