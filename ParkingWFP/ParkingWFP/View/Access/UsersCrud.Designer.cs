namespace ParkingWFP.View.Access
{
    partial class UsersCrud
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
            this.btn_clearUsersForm = new System.Windows.Forms.Button();
            this.btn_removeUser = new System.Windows.Forms.Button();
            this.grid_users = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEnabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_saveUser = new System.Windows.Forms.Button();
            this.cbx_accessType = new System.Windows.Forms.ComboBox();
            this.lbl_userAccess = new System.Windows.Forms.Label();
            this.ckb_enabled = new System.Windows.Forms.CheckBox();
            this.lbl_enabled = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tbx_fullname = new System.Windows.Forms.TextBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tbx_confirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_usersCrud = new System.Windows.Forms.Panel();
            this.panel_usersCrudTextBoxes = new System.Windows.Forms.Panel();
            this.panel_usersCrudLabels = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).BeginInit();
            this.panel_usersCrud.SuspendLayout();
            this.panel_usersCrudTextBoxes.SuspendLayout();
            this.panel_usersCrudLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clearUsersForm
            // 
            this.btn_clearUsersForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_clearUsersForm.FlatAppearance.BorderSize = 0;
            this.btn_clearUsersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearUsersForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearUsersForm.ForeColor = System.Drawing.Color.White;
            this.btn_clearUsersForm.Location = new System.Drawing.Point(23, 460);
            this.btn_clearUsersForm.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_clearUsersForm.Name = "btn_clearUsersForm";
            this.btn_clearUsersForm.Size = new System.Drawing.Size(145, 40);
            this.btn_clearUsersForm.TabIndex = 10;
            this.btn_clearUsersForm.Text = "Limpar";
            this.btn_clearUsersForm.UseVisualStyleBackColor = false;
            this.btn_clearUsersForm.Click += new System.EventHandler(this.btn_clearUsersForm_Click);
            // 
            // btn_removeUser
            // 
            this.btn_removeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_removeUser.FlatAppearance.BorderSize = 0;
            this.btn_removeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeUser.ForeColor = System.Drawing.Color.White;
            this.btn_removeUser.Location = new System.Drawing.Point(176, 460);
            this.btn_removeUser.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_removeUser.Name = "btn_removeUser";
            this.btn_removeUser.Size = new System.Drawing.Size(145, 40);
            this.btn_removeUser.TabIndex = 9;
            this.btn_removeUser.Text = "Remover";
            this.btn_removeUser.UseVisualStyleBackColor = false;
            this.btn_removeUser.Click += new System.EventHandler(this.btn_removeUser_Click);
            // 
            // grid_users
            // 
            this.grid_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_users.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.Username,
            this.Email,
            this.Password,
            this.Fullname,
            this.isEnabled,
            this.AccessType,
            this.CreatedAt,
            this.UpdatedAt});
            this.grid_users.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_users.Location = new System.Drawing.Point(24, 544);
            this.grid_users.Margin = new System.Windows.Forms.Padding(4);
            this.grid_users.Name = "grid_users";
            this.grid_users.RowTemplate.Height = 24;
            this.grid_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_users.Size = new System.Drawing.Size(458, 197);
            this.grid_users.TabIndex = 11;
            this.grid_users.DoubleClick += new System.EventHandler(this.grid_users_DoubleClick);
            // 
            // IdUser
            // 
            this.IdUser.DataPropertyName = "IdUser";
            this.IdUser.HeaderText = "Código";
            this.IdUser.Name = "IdUser";
            this.IdUser.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Usuário";
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Senha";
            this.Password.Name = "Password";
            this.Password.Visible = false;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Nome Completo";
            this.Fullname.Name = "Fullname";
            // 
            // isEnabled
            // 
            this.isEnabled.DataPropertyName = "Enabled";
            this.isEnabled.HeaderText = "Ativo";
            this.isEnabled.Name = "isEnabled";
            // 
            // AccessType
            // 
            this.AccessType.DataPropertyName = "AccessType";
            this.AccessType.HeaderText = "Tipo de Acesso";
            this.AccessType.Name = "AccessType";
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Data de Criação";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Visible = false;
            // 
            // UpdatedAt
            // 
            this.UpdatedAt.DataPropertyName = "UpdatedAt";
            this.UpdatedAt.HeaderText = "Data de Atualização";
            this.UpdatedAt.Name = "UpdatedAt";
            this.UpdatedAt.Visible = false;
            // 
            // btn_saveUser
            // 
            this.btn_saveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_saveUser.FlatAppearance.BorderSize = 0;
            this.btn_saveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveUser.ForeColor = System.Drawing.Color.White;
            this.btn_saveUser.Location = new System.Drawing.Point(329, 460);
            this.btn_saveUser.Margin = new System.Windows.Forms.Padding(4, 20, 4, 20);
            this.btn_saveUser.Name = "btn_saveUser";
            this.btn_saveUser.Size = new System.Drawing.Size(145, 40);
            this.btn_saveUser.TabIndex = 8;
            this.btn_saveUser.Text = "Adicionar";
            this.btn_saveUser.UseVisualStyleBackColor = false;
            this.btn_saveUser.Click += new System.EventHandler(this.btn_saveUser_Click);
            // 
            // cbx_accessType
            // 
            this.cbx_accessType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_accessType.FormattingEnabled = true;
            this.cbx_accessType.Items.AddRange(new object[] {
            "Administrador",
            "Atendente",
            "Outros"});
            this.cbx_accessType.Location = new System.Drawing.Point(24, 372);
            this.cbx_accessType.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_accessType.Name = "cbx_accessType";
            this.cbx_accessType.Size = new System.Drawing.Size(450, 31);
            this.cbx_accessType.TabIndex = 6;
            // 
            // lbl_userAccess
            // 
            this.lbl_userAccess.AutoSize = true;
            this.lbl_userAccess.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userAccess.Location = new System.Drawing.Point(24, 345);
            this.lbl_userAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userAccess.Name = "lbl_userAccess";
            this.lbl_userAccess.Size = new System.Drawing.Size(150, 23);
            this.lbl_userAccess.TabIndex = 34;
            this.lbl_userAccess.Text = "Tipo de acesso:";
            // 
            // ckb_enabled
            // 
            this.ckb_enabled.AutoSize = true;
            this.ckb_enabled.Checked = true;
            this.ckb_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_enabled.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_enabled.Location = new System.Drawing.Point(88, 413);
            this.ckb_enabled.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_enabled.Name = "ckb_enabled";
            this.ckb_enabled.Size = new System.Drawing.Size(18, 17);
            this.ckb_enabled.TabIndex = 7;
            this.ckb_enabled.UseVisualStyleBackColor = true;
            // 
            // lbl_enabled
            // 
            this.lbl_enabled.AutoSize = true;
            this.lbl_enabled.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enabled.Location = new System.Drawing.Point(26, 407);
            this.lbl_enabled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_enabled.Name = "lbl_enabled";
            this.lbl_enabled.Size = new System.Drawing.Size(59, 23);
            this.lbl_enabled.TabIndex = 32;
            this.lbl_enabled.Text = "Ativo:";
            // 
            // tbx_email
            // 
            this.tbx_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_email.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(24, 177);
            this.tbx_email.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(446, 34);
            this.tbx_email.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(24, 150);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(64, 23);
            this.lbl_email.TabIndex = 30;
            this.lbl_email.Text = "Email:";
            // 
            // tbx_fullname
            // 
            this.tbx_fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_fullname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_fullname.Location = new System.Drawing.Point(24, 47);
            this.tbx_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_fullname.Name = "tbx_fullname";
            this.tbx_fullname.Size = new System.Drawing.Size(450, 34);
            this.tbx_fullname.TabIndex = 1;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.Location = new System.Drawing.Point(24, 20);
            this.lbl_fullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(153, 23);
            this.lbl_fullname.TabIndex = 28;
            this.lbl_fullname.Text = "Nome completo:";
            // 
            // tbx_password
            // 
            this.tbx_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_password.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(24, 242);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(450, 34);
            this.tbx_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(24, 215);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 23);
            this.lbl_password.TabIndex = 26;
            this.lbl_password.Text = "Senha:";
            // 
            // tbx_username
            // 
            this.tbx_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_username.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(24, 112);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(450, 34);
            this.tbx_username.TabIndex = 2;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(24, 85);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(82, 23);
            this.lbl_user.TabIndex = 24;
            this.lbl_user.Text = "Usuário:";
            // 
            // tbx_confirmPassword
            // 
            this.tbx_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_confirmPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_confirmPassword.Location = new System.Drawing.Point(24, 307);
            this.tbx_confirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_confirmPassword.Name = "tbx_confirmPassword";
            this.tbx_confirmPassword.PasswordChar = '*';
            this.tbx_confirmPassword.Size = new System.Drawing.Size(450, 34);
            this.tbx_confirmPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Confirmar senha:";
            // 
            // panel_usersCrud
            // 
            this.panel_usersCrud.Controls.Add(this.panel_usersCrudTextBoxes);
            this.panel_usersCrud.Controls.Add(this.panel_usersCrudLabels);
            this.panel_usersCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_usersCrud.Location = new System.Drawing.Point(0, 0);
            this.panel_usersCrud.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usersCrud.Name = "panel_usersCrud";
            this.panel_usersCrud.Size = new System.Drawing.Size(505, 820);
            this.panel_usersCrud.TabIndex = 42;
            // 
            // panel_usersCrudTextBoxes
            // 
            this.panel_usersCrudTextBoxes.AutoScroll = true;
            this.panel_usersCrudTextBoxes.BackColor = System.Drawing.SystemColors.Control;
            this.panel_usersCrudTextBoxes.Controls.Add(this.grid_users);
            this.panel_usersCrudTextBoxes.Controls.Add(this.tbx_confirmPassword);
            this.panel_usersCrudTextBoxes.Controls.Add(this.tbx_username);
            this.panel_usersCrudTextBoxes.Controls.Add(this.btn_clearUsersForm);
            this.panel_usersCrudTextBoxes.Controls.Add(this.lbl_user);
            this.panel_usersCrudTextBoxes.Controls.Add(this.tbx_password);
            this.panel_usersCrudTextBoxes.Controls.Add(this.btn_removeUser);
            this.panel_usersCrudTextBoxes.Controls.Add(this.lbl_fullname);
            this.panel_usersCrudTextBoxes.Controls.Add(this.btn_saveUser);
            this.panel_usersCrudTextBoxes.Controls.Add(this.lbl_enabled);
            this.panel_usersCrudTextBoxes.Controls.Add(this.tbx_fullname);
            this.panel_usersCrudTextBoxes.Controls.Add(this.lbl_password);
            this.panel_usersCrudTextBoxes.Controls.Add(this.cbx_accessType);
            this.panel_usersCrudTextBoxes.Controls.Add(this.lbl_userAccess);
            this.panel_usersCrudTextBoxes.Controls.Add(this.tbx_email);
            this.panel_usersCrudTextBoxes.Controls.Add(this.label1);
            this.panel_usersCrudTextBoxes.Controls.Add(this.ckb_enabled);
            this.panel_usersCrudTextBoxes.Controls.Add(this.lbl_email);
            this.panel_usersCrudTextBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_usersCrudTextBoxes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_usersCrudTextBoxes.Location = new System.Drawing.Point(0, 55);
            this.panel_usersCrudTextBoxes.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usersCrudTextBoxes.Name = "panel_usersCrudTextBoxes";
            this.panel_usersCrudTextBoxes.Padding = new System.Windows.Forms.Padding(20);
            this.panel_usersCrudTextBoxes.Size = new System.Drawing.Size(505, 765);
            this.panel_usersCrudTextBoxes.TabIndex = 42;
            // 
            // panel_usersCrudLabels
            // 
            this.panel_usersCrudLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_usersCrudLabels.Controls.Add(this.pictureBox1);
            this.panel_usersCrudLabels.Controls.Add(this.lbl_title);
            this.panel_usersCrudLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_usersCrudLabels.Location = new System.Drawing.Point(0, 0);
            this.panel_usersCrudLabels.Margin = new System.Windows.Forms.Padding(4);
            this.panel_usersCrudLabels.Name = "panel_usersCrudLabels";
            this.panel_usersCrudLabels.Size = new System.Drawing.Size(505, 55);
            this.panel_usersCrudLabels.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParkingWFP.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(75, 13);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(134, 35);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Usuários";
            // 
            // UsersCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(505, 820);
            this.Controls.Add(this.panel_usersCrud);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersCrud";
            this.Text = "UsersCrud";
            this.Load += new System.EventHandler(this.UsersCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_users)).EndInit();
            this.panel_usersCrud.ResumeLayout(false);
            this.panel_usersCrudTextBoxes.ResumeLayout(false);
            this.panel_usersCrudTextBoxes.PerformLayout();
            this.panel_usersCrudLabels.ResumeLayout(false);
            this.panel_usersCrudLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clearUsersForm;
        private System.Windows.Forms.Button btn_removeUser;
        private System.Windows.Forms.DataGridView grid_users;
        private System.Windows.Forms.Button btn_saveUser;
        private System.Windows.Forms.ComboBox cbx_accessType;
        private System.Windows.Forms.Label lbl_userAccess;
        private System.Windows.Forms.CheckBox ckb_enabled;
        private System.Windows.Forms.Label lbl_enabled;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tbx_fullname;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox tbx_confirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_usersCrud;
        private System.Windows.Forms.Panel panel_usersCrudLabels;
        private System.Windows.Forms.Panel panel_usersCrudTextBoxes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedAt;
    }
}