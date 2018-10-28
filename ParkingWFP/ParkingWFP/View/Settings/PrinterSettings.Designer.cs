namespace ParkingWFP.View.Settings
{
    partial class PrinterSettings
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
            this.btn_updatePrinters = new System.Windows.Forms.Button();
            this.txb_footer = new System.Windows.Forms.TextBox();
            this.lbl_footer = new System.Windows.Forms.Label();
            this.txb_header = new System.Windows.Forms.TextBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txb_host = new System.Windows.Forms.TextBox();
            this.lbl_host = new System.Windows.Forms.Label();
            this.txb_model = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.panel_title = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_updatePrinters
            // 
            this.btn_updatePrinters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_updatePrinters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePrinters.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePrinters.ForeColor = System.Drawing.Color.White;
            this.btn_updatePrinters.Location = new System.Drawing.Point(665, 428);
            this.btn_updatePrinters.Name = "btn_updatePrinters";
            this.btn_updatePrinters.Size = new System.Drawing.Size(130, 40);
            this.btn_updatePrinters.TabIndex = 26;
            this.btn_updatePrinters.Text = "Atualizar";
            this.btn_updatePrinters.UseVisualStyleBackColor = false;
            this.btn_updatePrinters.Click += new System.EventHandler(this.btn_updatePrinters_Click);
            // 
            // txb_footer
            // 
            this.txb_footer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_footer.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_footer.Location = new System.Drawing.Point(190, 289);
            this.txb_footer.Multiline = true;
            this.txb_footer.Name = "txb_footer";
            this.txb_footer.Size = new System.Drawing.Size(605, 99);
            this.txb_footer.TabIndex = 25;
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.Location = new System.Drawing.Point(84, 291);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(85, 23);
            this.lbl_footer.TabIndex = 24;
            this.lbl_footer.Text = "Rodapé:";
            // 
            // txb_header
            // 
            this.txb_header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_header.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_header.Location = new System.Drawing.Point(190, 184);
            this.txb_header.Multiline = true;
            this.txb_header.Name = "txb_header";
            this.txb_header.Size = new System.Drawing.Size(605, 99);
            this.txb_header.TabIndex = 23;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(60, 186);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(109, 23);
            this.lbl_header.TabIndex = 22;
            this.lbl_header.Text = "Cabeçalho:";
            // 
            // txb_port
            // 
            this.txb_port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_port.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_port.Location = new System.Drawing.Point(190, 151);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(605, 27);
            this.txb_port.TabIndex = 21;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_port.Location = new System.Drawing.Point(105, 153);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(64, 23);
            this.lbl_port.TabIndex = 20;
            this.lbl_port.Text = "Porta:";
            // 
            // txb_host
            // 
            this.txb_host.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_host.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_host.Location = new System.Drawing.Point(190, 118);
            this.txb_host.Name = "txb_host";
            this.txb_host.Size = new System.Drawing.Size(605, 27);
            this.txb_host.TabIndex = 19;
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_host.Location = new System.Drawing.Point(113, 120);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(56, 23);
            this.lbl_host.TabIndex = 18;
            this.lbl_host.Text = "Host:";
            // 
            // txb_model
            // 
            this.txb_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_model.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_model.Location = new System.Drawing.Point(190, 85);
            this.txb_model.Name = "txb_model";
            this.txb_model.Size = new System.Drawing.Size(605, 27);
            this.txb_model.TabIndex = 17;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(88, 87);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(81, 23);
            this.lbl_model.TabIndex = 16;
            this.lbl_model.Text = "Modelo:";
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_title.Controls.Add(this.pictureBox1);
            this.panel_title.Controls.Add(this.lbl_title);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_title.ForeColor = System.Drawing.Color.White;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(828, 50);
            this.panel_title.TabIndex = 27;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(58, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(162, 35);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Impressora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingWFP.Properties.Resources.printer;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PrinterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 501);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.btn_updatePrinters);
            this.Controls.Add(this.txb_footer);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.txb_header);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.txb_port);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.txb_host);
            this.Controls.Add(this.lbl_host);
            this.Controls.Add(this.txb_model);
            this.Controls.Add(this.lbl_model);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrinterSettings";
            this.Text = "PrinterSettings";
            this.Load += new System.EventHandler(this.PrinterSettings_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updatePrinters;
        private System.Windows.Forms.TextBox txb_footer;
        private System.Windows.Forms.Label lbl_footer;
        private System.Windows.Forms.TextBox txb_header;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txb_host;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.TextBox txb_model;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}