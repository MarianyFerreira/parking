namespace ParkingWFP.View.Access
{
    partial class Login
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.cbx_users = new System.Windows.Forms.ComboBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_authentication = new System.Windows.Forms.Label();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(23, 90);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 23);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Usuário";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(27, 229);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(319, 58);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Autenticar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txb_password
            // 
            this.txb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_password.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.Location = new System.Drawing.Point(27, 183);
            this.txb_password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.Size = new System.Drawing.Size(319, 34);
            this.txb_password.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(23, 156);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(65, 23);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Senha";
            // 
            // cbx_users
            // 
            this.cbx_users.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_users.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_users.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_users.FormattingEnabled = true;
            this.cbx_users.Location = new System.Drawing.Point(27, 117);
            this.cbx_users.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_users.Name = "cbx_users";
            this.cbx_users.Size = new System.Drawing.Size(318, 31);
            this.cbx_users.TabIndex = 1;
            this.cbx_users.SelectedValueChanged += new System.EventHandler(this.cbx_users_SelectedValueChanged);
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_title.Controls.Add(this.pictureBox1);
            this.panel_title.Controls.Add(this.label_authentication);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.ForeColor = System.Drawing.Color.White;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(373, 55);
            this.panel_title.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingWFP.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(27, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_authentication
            // 
            this.label_authentication.AutoSize = true;
            this.label_authentication.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_authentication.ForeColor = System.Drawing.Color.White;
            this.label_authentication.Location = new System.Drawing.Point(75, 9);
            this.label_authentication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_authentication.Name = "label_authentication";
            this.label_authentication.Size = new System.Drawing.Size(186, 35);
            this.label_authentication.TabIndex = 2;
            this.label_authentication.Text = "Autenticação";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(373, 317);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.cbx_users);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_username);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.ComboBox cbx_users;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_authentication;
    }
}