/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Model;
using ParkingWFP.View.Access;
using ParkingWFP.View.Settings;
using ParkingWFP.View.Vehicles;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View
{
    public partial class Main : Form
    {
        User user = new User();
        bool admin = false;

        public Main()
        {
            using (var loginForm = new Login())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
                user = loginForm.user;
            }

            InitializeComponent();
        }

        private void ShowMainPanelForm(object form)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.RemoveAt(0);
            }
            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;

            panel_main.Controls.Add(newForm);
            panel_main.Tag = newForm;
            newForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.RemoveAt(0);
            }
            var dashboard = new Dashboard();
            dashboard.user = user;
            Form newForm = dashboard as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;

            panel_main.Controls.Add(newForm);
            panel_main.Tag = newForm;
            newForm.Show();
        }

        private void btn_parking_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.RemoveAt(0);
            }
            var dashboard = new Dashboard();
            dashboard.user = user;
            Form newForm = dashboard as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;

            panel_main.Controls.Add(newForm);
            panel_main.Tag = newForm;
            newForm.Show();
        }

        private void btn_printer_Click(object sender, EventArgs e)
        {
            ShowMainPanelForm(new PrinterSettings());
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            bool admin = false;
            using (var loginForm = new AdminLogin())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
            }

            if (admin)
            {
                ShowMainPanelForm(new UsersCrud());
            }
        }

        private void btn_vehicles_Click(object sender, EventArgs e)
        {
            panel_vehiclesOptions.Visible = !panel_vehiclesOptions.Visible;
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            bool admin = false;
            using (var loginForm = new AdminLogin())
            {
                loginForm.ShowDialog();
                admin = loginForm.isAdmin;
            }

            if (admin)
            {
                ShowMainPanelForm(new CategoriesCrud());
            }
        }

        private void btn_colors_Click(object sender, EventArgs e)
        {
            ShowMainPanelForm(new ColorsCrud());
        }

        private void btn_models_Click(object sender, EventArgs e)
        {
            ShowMainPanelForm(new VehicleModelCrud());
        }
    }
}
