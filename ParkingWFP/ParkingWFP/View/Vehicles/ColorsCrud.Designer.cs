namespace ParkingWFP.View.Vehicles
{
    partial class ColorsCrud
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
            this.lbl_vehicleColor = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_color = new System.Windows.Forms.TextBox();
            this.panel_gridColors = new System.Windows.Forms.Panel();
            this.grid_vehicleColors = new System.Windows.Forms.DataGridView();
            this.IdVehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_usersCrudLabels.SuspendLayout();
            this.panel_gridColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel_usersCrudLabels.TabIndex = 43;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(60, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(94, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Cores";
            // 
            // btn_clearForm
            // 
            this.btn_clearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_clearForm.FlatAppearance.BorderSize = 0;
            this.btn_clearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearForm.Location = new System.Drawing.Point(258, 152);
            this.btn_clearForm.Name = "btn_clearForm";
            this.btn_clearForm.Size = new System.Drawing.Size(130, 40);
            this.btn_clearForm.TabIndex = 49;
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
            this.btn_remove.Location = new System.Drawing.Point(394, 152);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(130, 40);
            this.btn_remove.TabIndex = 48;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_vehicleColor
            // 
            this.lbl_vehicleColor.AutoSize = true;
            this.lbl_vehicleColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleColor.Location = new System.Drawing.Point(126, 86);
            this.lbl_vehicleColor.Name = "lbl_vehicleColor";
            this.lbl_vehicleColor.Size = new System.Drawing.Size(48, 23);
            this.lbl_vehicleColor.TabIndex = 51;
            this.lbl_vehicleColor.Text = "Cor:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(530, 152);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 40);
            this.btn_save.TabIndex = 47;
            this.btn_save.Text = "Adicionar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_color
            // 
            this.tbx_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_color.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_color.Location = new System.Drawing.Point(200, 84);
            this.tbx_color.MaxLength = 200;
            this.tbx_color.Name = "tbx_color";
            this.tbx_color.Size = new System.Drawing.Size(460, 27);
            this.tbx_color.TabIndex = 44;
            // 
            // panel_gridColors
            // 
            this.panel_gridColors.Controls.Add(this.grid_vehicleColors);
            this.panel_gridColors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_gridColors.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_gridColors.Location = new System.Drawing.Point(0, 198);
            this.panel_gridColors.Name = "panel_gridColors";
            this.panel_gridColors.Size = new System.Drawing.Size(800, 335);
            this.panel_gridColors.TabIndex = 52;
            // 
            // grid_vehicleColors
            // 
            this.grid_vehicleColors.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_vehicleColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vehicleColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehicleColor,
            this.Color,
            this.CreatedAt,
            this.UpdatedAt});
            this.grid_vehicleColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_vehicleColors.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_vehicleColors.Location = new System.Drawing.Point(0, 0);
            this.grid_vehicleColors.Name = "grid_vehicleColors";
            this.grid_vehicleColors.RowTemplate.Height = 24;
            this.grid_vehicleColors.Size = new System.Drawing.Size(800, 335);
            this.grid_vehicleColors.TabIndex = 0;
            this.grid_vehicleColors.DoubleClick += new System.EventHandler(this.grid_vehicleColors_DoubleClick);
            // 
            // IdVehicleColor
            // 
            this.IdVehicleColor.DataPropertyName = "IdVehicleColor";
            this.IdVehicleColor.HeaderText = "Código";
            this.IdVehicleColor.Name = "IdVehicleColor";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Cor";
            this.Color.Name = "Color";
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
            // ColorsCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panel_gridColors);
            this.Controls.Add(this.btn_clearForm);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_vehicleColor);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbx_color);
            this.Controls.Add(this.panel_usersCrudLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorsCrud";
            this.Text = "ColorsCrud";
            this.Load += new System.EventHandler(this.ColorsCrud_Load);
            this.panel_usersCrudLabels.ResumeLayout(false);
            this.panel_usersCrudLabels.PerformLayout();
            this.panel_gridColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_usersCrudLabels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clearForm;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_vehicleColor;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_color;
        private System.Windows.Forms.Panel panel_gridColors;
        private System.Windows.Forms.DataGridView grid_vehicleColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}