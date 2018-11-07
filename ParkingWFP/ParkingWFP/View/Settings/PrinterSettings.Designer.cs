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
            this.panel_title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_testPrinter = new System.Windows.Forms.Button();
            this.btn_testPrinterConnection = new System.Windows.Forms.Button();
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
            this.btn_updatePrinters.Location = new System.Drawing.Point(437, 446);
            this.btn_updatePrinters.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updatePrinters.Name = "btn_updatePrinters";
            this.btn_updatePrinters.Size = new System.Drawing.Size(145, 40);
            this.btn_updatePrinters.TabIndex = 26;
            this.btn_updatePrinters.Text = "Atualizar";
            this.btn_updatePrinters.UseVisualStyleBackColor = false;
            this.btn_updatePrinters.Click += new System.EventHandler(this.btn_updatePrinters_Click);
            // 
            // txb_footer
            // 
            this.txb_footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_footer.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_footer.Location = new System.Drawing.Point(23, 276);
            this.txb_footer.Margin = new System.Windows.Forms.Padding(4);
            this.txb_footer.Multiline = true;
            this.txb_footer.Name = "txb_footer";
            this.txb_footer.Size = new System.Drawing.Size(559, 142);
            this.txb_footer.TabIndex = 25;
            // 
            // lbl_footer
            // 
            this.lbl_footer.AutoSize = true;
            this.lbl_footer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.Location = new System.Drawing.Point(19, 249);
            this.lbl_footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(85, 23);
            this.lbl_footer.TabIndex = 24;
            this.lbl_footer.Text = "Rodapé:";
            // 
            // txb_header
            // 
            this.txb_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_header.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_header.Location = new System.Drawing.Point(23, 123);
            this.txb_header.Margin = new System.Windows.Forms.Padding(4);
            this.txb_header.Multiline = true;
            this.txb_header.Name = "txb_header";
            this.txb_header.Size = new System.Drawing.Size(559, 113);
            this.txb_header.TabIndex = 23;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(19, 96);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(109, 23);
            this.lbl_header.TabIndex = 22;
            this.lbl_header.Text = "Cabeçalho:";
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
            this.panel_title.Margin = new System.Windows.Forms.Padding(28, 4, 4, 4);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(611, 55);
            this.panel_title.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingWFP.Properties.Resources.printer;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(60, 13);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(162, 35);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Impressora";
            // 
            // btn_testPrinter
            // 
            this.btn_testPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_testPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_testPrinter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testPrinter.ForeColor = System.Drawing.Color.White;
            this.btn_testPrinter.Location = new System.Drawing.Point(230, 446);
            this.btn_testPrinter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_testPrinter.Name = "btn_testPrinter";
            this.btn_testPrinter.Size = new System.Drawing.Size(199, 40);
            this.btn_testPrinter.TabIndex = 34;
            this.btn_testPrinter.Text = "Testar Impressão";
            this.btn_testPrinter.UseVisualStyleBackColor = false;
            this.btn_testPrinter.Click += new System.EventHandler(this.btn_testPrinter_Click);
            // 
            // btn_testPrinterConnection
            // 
            this.btn_testPrinterConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_testPrinterConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_testPrinterConnection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testPrinterConnection.ForeColor = System.Drawing.Color.White;
            this.btn_testPrinterConnection.Location = new System.Drawing.Point(23, 446);
            this.btn_testPrinterConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btn_testPrinterConnection.Name = "btn_testPrinterConnection";
            this.btn_testPrinterConnection.Size = new System.Drawing.Size(199, 40);
            this.btn_testPrinterConnection.TabIndex = 35;
            this.btn_testPrinterConnection.Text = "Testar Conexão";
            this.btn_testPrinterConnection.UseVisualStyleBackColor = false;
            this.btn_testPrinterConnection.Click += new System.EventHandler(this.btn_testPrinterConnection_Click);
            // 
            // PrinterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(611, 572);
            this.Controls.Add(this.btn_testPrinterConnection);
            this.Controls.Add(this.btn_testPrinter);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.btn_updatePrinters);
            this.Controls.Add(this.txb_footer);
            this.Controls.Add(this.lbl_footer);
            this.Controls.Add(this.txb_header);
            this.Controls.Add(this.lbl_header);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_testPrinter;
        private System.Windows.Forms.Button btn_testPrinterConnection;
    }
}