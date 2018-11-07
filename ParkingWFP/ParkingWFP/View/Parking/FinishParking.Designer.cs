namespace ParkingWFP.View
{
    partial class FinishParking
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_authentication = new System.Windows.Forms.Label();
            this.btn_finishParking = new System.Windows.Forms.Button();
            this.btn_cancelParking = new System.Windows.Forms.Button();
            this.tbx_discount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_increase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_idParkingDescription = new System.Windows.Forms.TextBox();
            this.tbx_plateDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_startDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_finishDescription = new System.Windows.Forms.TextBox();
            this.tbx_overplus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_valueReceived = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_permanenceTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_title.Controls.Add(this.label_authentication);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.ForeColor = System.Drawing.Color.White;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Margin = new System.Windows.Forms.Padding(4);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(522, 55);
            this.panel_title.TabIndex = 25;
            // 
            // label_authentication
            // 
            this.label_authentication.AutoSize = true;
            this.label_authentication.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authentication.ForeColor = System.Drawing.Color.White;
            this.label_authentication.Location = new System.Drawing.Point(30, 13);
            this.label_authentication.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_authentication.Name = "label_authentication";
            this.label_authentication.Size = new System.Drawing.Size(427, 35);
            this.label_authentication.TabIndex = 2;
            this.label_authentication.Text = "Finalização de Estacionamento";
            // 
            // btn_finishParking
            // 
            this.btn_finishParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_finishParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_finishParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finishParking.ForeColor = System.Drawing.Color.White;
            this.btn_finishParking.Location = new System.Drawing.Point(256, 575);
            this.btn_finishParking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_finishParking.Name = "btn_finishParking";
            this.btn_finishParking.Size = new System.Drawing.Size(230, 50);
            this.btn_finishParking.TabIndex = 39;
            this.btn_finishParking.Text = "Finalizar";
            this.btn_finishParking.UseVisualStyleBackColor = false;
            this.btn_finishParking.Click += new System.EventHandler(this.btn_finishParking_Click);
            // 
            // btn_cancelParking
            // 
            this.btn_cancelParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(250)))));
            this.btn_cancelParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelParking.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelParking.Location = new System.Drawing.Point(36, 575);
            this.btn_cancelParking.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelParking.Name = "btn_cancelParking";
            this.btn_cancelParking.Size = new System.Drawing.Size(212, 50);
            this.btn_cancelParking.TabIndex = 40;
            this.btn_cancelParking.Text = "Cancelar";
            this.btn_cancelParking.UseVisualStyleBackColor = false;
            this.btn_cancelParking.Click += new System.EventHandler(this.btn_cancelParking_Click);
            // 
            // tbx_discount
            // 
            this.tbx_discount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_discount.Location = new System.Drawing.Point(41, 683);
            this.tbx_discount.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_discount.Name = "tbx_discount";
            this.tbx_discount.Size = new System.Drawing.Size(210, 30);
            this.tbx_discount.TabIndex = 45;
            this.tbx_discount.Text = "0,00";
            this.tbx_discount.TextChanged += new System.EventHandler(this.tbx_discount_TextChanged);
            this.tbx_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_discount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 657);
            this.label8.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Desconto:";
            // 
            // tbx_increase
            // 
            this.tbx_increase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_increase.Location = new System.Drawing.Point(281, 683);
            this.tbx_increase.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_increase.Name = "tbx_increase";
            this.tbx_increase.Size = new System.Drawing.Size(210, 30);
            this.tbx_increase.TabIndex = 47;
            this.tbx_increase.Text = "0,00";
            this.tbx_increase.TextChanged += new System.EventHandler(this.tbx_increase_TextChanged);
            this.tbx_increase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_increase_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 657);
            this.label9.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Acréscimo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Placa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Comanda:";
            // 
            // tbx_idParkingDescription
            // 
            this.tbx_idParkingDescription.Enabled = false;
            this.tbx_idParkingDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_idParkingDescription.Location = new System.Drawing.Point(271, 102);
            this.tbx_idParkingDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_idParkingDescription.Name = "tbx_idParkingDescription";
            this.tbx_idParkingDescription.Size = new System.Drawing.Size(215, 27);
            this.tbx_idParkingDescription.TabIndex = 37;
            // 
            // tbx_plateDescription
            // 
            this.tbx_plateDescription.Enabled = false;
            this.tbx_plateDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_plateDescription.Location = new System.Drawing.Point(36, 102);
            this.tbx_plateDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_plateDescription.Name = "tbx_plateDescription";
            this.tbx_plateDescription.Size = new System.Drawing.Size(215, 27);
            this.tbx_plateDescription.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Entrada:";
            // 
            // tbx_startDescription
            // 
            this.tbx_startDescription.Enabled = false;
            this.tbx_startDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_startDescription.Location = new System.Drawing.Point(36, 155);
            this.tbx_startDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_startDescription.Name = "tbx_startDescription";
            this.tbx_startDescription.Size = new System.Drawing.Size(215, 27);
            this.tbx_startDescription.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Saída:";
            // 
            // tbx_finishDescription
            // 
            this.tbx_finishDescription.Enabled = false;
            this.tbx_finishDescription.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_finishDescription.Location = new System.Drawing.Point(271, 155);
            this.tbx_finishDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_finishDescription.Name = "tbx_finishDescription";
            this.tbx_finishDescription.Size = new System.Drawing.Size(215, 27);
            this.tbx_finishDescription.TabIndex = 43;
            // 
            // tbx_overplus
            // 
            this.tbx_overplus.Enabled = false;
            this.tbx_overplus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_overplus.Location = new System.Drawing.Point(193, 462);
            this.tbx_overplus.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_overplus.Name = "tbx_overplus";
            this.tbx_overplus.Size = new System.Drawing.Size(293, 30);
            this.tbx_overplus.TabIndex = 51;
            this.tbx_overplus.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Troco:";
            // 
            // tbx_valueReceived
            // 
            this.tbx_valueReceived.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_valueReceived.Location = new System.Drawing.Point(193, 418);
            this.tbx_valueReceived.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_valueReceived.Name = "tbx_valueReceived";
            this.tbx_valueReceived.Size = new System.Drawing.Size(293, 30);
            this.tbx_valueReceived.TabIndex = 49;
            this.tbx_valueReceived.Text = "0,00";
            this.tbx_valueReceived.TextChanged += new System.EventHandler(this.tbx_valueReceived_TextChanged);
            this.tbx_valueReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_valueReceived_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Valor recebido:";
            // 
            // tbx_value
            // 
            this.tbx_value.Enabled = false;
            this.tbx_value.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_value.ForeColor = System.Drawing.Color.Red;
            this.tbx_value.Location = new System.Drawing.Point(193, 330);
            this.tbx_value.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_value.Name = "tbx_value";
            this.tbx_value.Size = new System.Drawing.Size(293, 42);
            this.tbx_value.TabIndex = 53;
            this.tbx_value.Text = "0,00";
            this.tbx_value.TextChanged += new System.EventHandler(this.tbx_value_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(55, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 35);
            this.label4.TabIndex = 54;
            this.label4.Text = "TOTAL:";
            // 
            // tbx_permanenceTime
            // 
            this.tbx_permanenceTime.Enabled = false;
            this.tbx_permanenceTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_permanenceTime.Location = new System.Drawing.Point(36, 217);
            this.tbx_permanenceTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_permanenceTime.Name = "tbx_permanenceTime";
            this.tbx_permanenceTime.Size = new System.Drawing.Size(215, 27);
            this.tbx_permanenceTime.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(28, 22, 14, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tempo de permanência:";
            // 
            // FinishParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 757);
            this.Controls.Add(this.tbx_permanenceTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_overplus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_valueReceived);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_increase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_discount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_finishDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_startDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancelParking);
            this.Controls.Add(this.btn_finishParking);
            this.Controls.Add(this.tbx_plateDescription);
            this.Controls.Add(this.tbx_idParkingDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinishParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FinishParking_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label_authentication;
        private System.Windows.Forms.Button btn_finishParking;
        private System.Windows.Forms.Button btn_cancelParking;
        private System.Windows.Forms.TextBox tbx_discount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_increase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_idParkingDescription;
        private System.Windows.Forms.TextBox tbx_plateDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_startDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_finishDescription;
        private System.Windows.Forms.TextBox tbx_overplus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_valueReceived;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_permanenceTime;
        private System.Windows.Forms.Label label10;
    }
}