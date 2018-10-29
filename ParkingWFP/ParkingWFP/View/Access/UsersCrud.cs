using ParkingWFP.Model;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View.Access
{
    public partial class UsersCrud : Form
    {
        public User user = new User();
        public UsersCrud()
        {
            InitializeComponent();
        }

        private void PopulateUsersGrid()
        {
            grid_users.AutoGenerateColumns = false;
            grid_users.DataSource = user.LoadUsersToList();
        }

        private void Clear()
        {
            tbx_username.Text = "";
            tbx_email.Text = "";
            tbx_password.Text = "";
            tbx_confirmPassword.Text = "";
            tbx_fullname.Text = "";
            ckb_enabled.Checked = true;
            cbx_accessType.SelectedIndex = 0;

            btn_removeUser.Enabled = false;
            btn_saveUser.Text = "Adicionar";

            user.IdUser = 0;

            PopulateUsersGrid();
        }

        private void UsersCrud_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private bool isValidUser()
        {
            var username = tbx_username.Text.Trim();
            var email = tbx_email.Text.Trim();
            var password = tbx_password.Text.Trim();
            var confirmPassword = tbx_confirmPassword.Text.Trim();
            var fullname = tbx_fullname.Text.Trim();
            var accessType = cbx_accessType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show($"Usuário é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show($"Email é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show($"Senha é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show($"Confirme a Senha");
                return false;
            }

            if (confirmPassword != password)
            {
                MessageBox.Show($"As senhas não correspondem");
                return false;
            }

            if (string.IsNullOrWhiteSpace(fullname))
            {
                MessageBox.Show($"Nome Completo é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(accessType))
            {
                MessageBox.Show($"Tipo de Acessp é um campo obrigatório");
                return false;
            }

            if(user.IdUser == 0 && user.ExistsUsername(username))
            {
                MessageBox.Show($"O Usuário {username} já existe no banco de dados ");
                return false;
            }

            return true;
        }

        private void btn_clearUsersForm_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_removeUser_Click(object sender, EventArgs e)
        {
            string msg = "Tem certeza que deseja remover esse usuário?";
            if (MessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (user.RemoveUser(user))
                {
                    Clear();
                    MessageBox.Show("Operação concluida");
                }
                else
                    MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
            }
        }

        private void btn_saveUser_Click(object sender, EventArgs e)
        {
            if(isValidUser() == false)
                return;
        
            user.Username = tbx_username.Text.Trim();
            user.Email = tbx_email.Text.Trim();
            user.Password = tbx_password.Text.Trim();
            user.Fullname = tbx_fullname.Text.Trim();
            user.Enabled = ckb_enabled.Checked;
            user.AccessType = cbx_accessType.SelectedItem.ToString();
            user.CreatedAt = user.IdUser == 0 ? DateTime.Now : user.CreatedAt;
            user.UpdatedAt = DateTime.Now;

            bool completed = false;
            if(user.IdUser == 0)
                completed = user.InsertUser(user);
            else
                completed = user.UpdateUser(user);
            if (completed)
            {
                Clear();
                MessageBox.Show("Operação concluida");
            } else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");
        }

        private void grid_users_DoubleClick(object sender, EventArgs e)
        {
            if(grid_users.CurrentRow.Index == -1)
                return;

            user.IdUser = Convert.ToInt32(grid_users.CurrentRow.Cells["IdUser"].Value);
            user = user.LoadUserById(user.IdUser);

            tbx_username.Text = user.Username;
            tbx_email.Text = user.Email;
            tbx_password.Text = user.Password;
            tbx_fullname.Text = user.Fullname;
            ckb_enabled.Checked = user.Enabled;
            cbx_accessType.SelectedItem = user.AccessType;

            btn_saveUser.Text = "Atualizar";
            btn_removeUser.Enabled = true;
        }
    }
}
