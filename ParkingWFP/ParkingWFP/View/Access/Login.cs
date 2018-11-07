/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System;
using System.Windows.Forms;
using ParkingWFP.Model;

namespace ParkingWFP.View.Access
{
    public partial class Login : Form
    {
        public User user = new User();
        public bool isAdmin = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PopulateUsers();
        }

        private void PopulateUsers()
        {
            cbx_users.DataSource = user.LoadAdminUsersToList();
            cbx_users.DisplayMember = "Username";
            cbx_users.ValueMember = "Username";
            cbx_users.SelectedIndex = 0;
        }

        private void cbx_users_SelectedValueChanged(object sender, EventArgs e)
        {
            var selected = cbx_users.SelectedValue;
            if (selected == null || selected.GetType() == typeof(User))
            {
                return;
            }

            user = user.LoadUserByUsername(selected.ToString());
        }

        public bool isValidUser(User user)
        {
            var password = txb_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show($"Senha é um campo obrigatório");
                return false;
            }

            if (user.Password != password)
            {
                MessageBox.Show($"A senha digitada está incorreta");
                return false;
            }
            return true;
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (isValidUser(user))
            {
                isAdmin = true;
                Close();
            }
        }
    }
}
