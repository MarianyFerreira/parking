using System;
using System.Linq;
using System.Windows.Forms;
using ParkingWFP.Model;

namespace ParkingWFP.View.Access
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool checkForm()
        {
            if (string.IsNullOrWhiteSpace(txb_username.Text))
            {
                MessageBox.Show($"Nome de usuário é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txb_password.Text))
            {
                MessageBox.Show($"Senha é um campo obrigatório");
                return false;
            }

            return true;
        }
 
        public bool checkUser(User user)
        {
            if (user == null)
            {
                MessageBox.Show($"Nome de usuário {txb_username.Text} não encontrado");
                return false;
            }

            return true;
        }

        public bool checkPassword(User user)
        {
            if (user.Password != txb_password.Text)
            {
                MessageBox.Show($"A senha digitada está incorreta");
                return false;
            }
            return true;
        }
 
        public User getUserByUsername(string Username)
        {
            User user;
            using (var db = new ParkingContext())
            {
                user = db.User
                    .Where(dbUser => dbUser.Username == Username)
                    .FirstOrDefault();
            }

            return user;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (checkForm() == false)
            {
                return;
            }

            User user = getUserByUsername(txb_username.Text);

            if (checkUser(user) && checkPassword(user))
            {
                MessageBox.Show($"Nome de usuário {txb_username.Text} e senha OK");
            }
        }
    }
}
