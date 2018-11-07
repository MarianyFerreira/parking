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
            this.grid_vehicleColors = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_colorFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdVehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_usersCrudLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleColors)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel_usersCrudLabels.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel_usersCrudLabels.Size = new System.Drawing.Size(506, 55);
            this.panel_usersCrudLabels.TabIndex = 43;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(22, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(94, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Cores";
            // 
            // btn_clearForm
            // 
            this.btn_clearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_clearForm.FlatAppearance.BorderSize = 0;
            this.btn_clearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearForm.Location = new System.Drawing.Point(28, 102);
            this.btn_clearForm.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_clearForm.Name = "btn_clearForm";
            this.btn_clearForm.Size = new System.Drawing.Size(145, 40);
            this.btn_clearForm.TabIndex = 49;
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
            this.btn_remove.Location = new System.Drawing.Point(181, 102);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(145, 40);
            this.btn_remove.TabIndex = 48;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_vehicleColor
            // 
            this.lbl_vehicleColor.AutoSize = true;
            this.lbl_vehicleColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleColor.Location = new System.Drawing.Point(24, 24);
            this.lbl_vehicleColor.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
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
            this.btn_save.Location = new System.Drawing.Point(334, 102);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 40);
            this.btn_save.TabIndex = 47;
            this.btn_save.Text = "Adicionar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_color
            // 
            this.tbx_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_color.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_color.Location = new System.Drawing.Point(28, 51);
            this.tbx_color.Margin = new System.Windows.Forms.Padding(28, 4, 4, 4);
            this.tbx_color.MaxLength = 200;
            this.tbx_color.Name = "tbx_color";
            this.tbx_color.Size = new System.Drawing.Size(451, 34);
            this.tbx_color.TabIndex = 44;
            // 
            // grid_vehicleColors
            // 
            this.grid_vehicleColors.AllowUserToAddRows = false;
            this.grid_vehicleColors.AllowUserToDeleteRows = false;
            this.grid_vehicleColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_vehicleColors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_vehicleColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_vehicleColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vehicleColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehicleColor,
            this.Color,
            this.CreatedAt,
            this.UpdatedAt});
            this.grid_vehicleColors.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_vehicleColors.Location = new System.Drawing.Point(28, 260);
            this.grid_vehicleColors.Margin = new System.Windows.Forms.Padding(20);
            this.grid_vehicleColors.Name = "grid_vehicleColors";
            this.grid_vehicleColors.ReadOnly = true;
            this.grid_vehicleColors.RowTemplate.Height = 24;
            this.grid_vehicleColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_vehicleColors.Size = new System.Drawing.Size(451, 208);
            this.grid_vehicleColors.TabIndex = 0;
            this.grid_vehicleColors.Click += new System.EventHandler(this.grid_vehicleColors_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tbx_colorFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_clearForm);
            this.panel1.Controls.Add(this.grid_vehicleColors);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.tbx_color);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.lbl_vehicleColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(506, 494);
            this.panel1.TabIndex = 50;
            // 
            // tbx_colorFilter
            // 
            this.tbx_colorFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbx_colorFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_colorFilter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_colorFilter.Location = new System.Drawing.Point(28, 225);
            this.tbx_colorFilter.Margin = new System.Windows.Forms.Padding(28, 4, 4, 4);
            this.tbx_colorFilter.MaxLength = 200;
            this.tbx_colorFilter.Name = "tbx_colorFilter";
            this.tbx_colorFilter.Size = new System.Drawing.Size(451, 34);
            this.tbx_colorFilter.TabIndex = 52;
            this.tbx_colorFilter.TextChanged += new System.EventHandler(this.tbx_colorFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Filtrar Cor:";
            // 
            // IdVehicleColor
            // 
            this.IdVehicleColor.DataPropertyName = "IdVehicleColor";
            this.IdVehicleColor.HeaderText = "Código";
            this.IdVehicleColor.MinimumWidth = 80;
            this.IdVehicleColor.Name = "IdVehicleColor";
            this.IdVehicleColor.ReadOnly = true;
            this.IdVehicleColor.Visible = false;
            this.IdVehicleColor.Width = 80;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Cor";
            this.Color.MinimumWidth = 200;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 300;
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
            // ColorsCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_usersCrudLabels);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorsCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ColorsCrud_Load);
            this.panel_usersCrudLabels.ResumeLayout(false);
            this.panel_usersCrudLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vehicleColors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_usersCrudLabels;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clearForm;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_vehicleColor;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_color;
        private System.Windows.Forms.DataGridView grid_vehicleColors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_colorFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}