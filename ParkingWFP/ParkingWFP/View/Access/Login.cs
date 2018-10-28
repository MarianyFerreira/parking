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
        User user = new User();
        public Login()
        {
            InitializeComponent();
        }

        public bool checkForm()
        {
            var username = txb_username.Text.Trim();
            var password = txb_password.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show($"Nome de usuário é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show($"Senha é um campo obrigatório");
                return false;
            }

            return true;
        }

        public bool isValidUser(User user)
        {
            if (user == null)
            {
                MessageBox.Show($"Usuário não encontrado");
                return false;
            }
            var password = txb_password.Text.Trim();
            if (user.Password != password)
            {
                MessageBox.Show($"A senha digitada está incorreta");
                return false;
            }
            return true;
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (checkForm() == false)
            {
                return;
            }

            var username = txb_username.Text.Trim();
            user = user.LoadUserByUsername(username);

            if (isValidUser(user))
            {
                Application.Run(new Main());
            }
            else
            {
                MessageBox.Show($"ERRO: Problema ao efetuar o Login");
            }
        }
    }
}
