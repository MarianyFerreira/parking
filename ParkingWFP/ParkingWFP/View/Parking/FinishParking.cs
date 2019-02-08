/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingWFP.View
{
    public partial class FinishParking : Form
    {

        public Parking parking = new Parking();
        VehicleCategory vehicleCategory = new VehicleCategory();
        VehicleModel vehicleModel = new VehicleModel();
        VehicleColor vehicleColor = new VehicleColor();


        public FinishParking()
        {
            InitializeComponent();
        }


        private void CheckKeyPress(KeyPressEventArgs e)
        {
            int backspace = 8;
            int comman = 44;
            char key = e.KeyChar;

            if (key == comman && lbl_value.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(key) && key != backspace && key != comman)
                e.Handled = true;
        }

        private void tbx_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKeyPress(e);
        }

        private void tbx_increase_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKeyPress(e);
        }

        private void tbx_valueReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckKeyPress(e);
        }

        private void CalculeParkingPermanenceTimeAndValues()
        {
            vehicleCategory = vehicleCategory.LoadCategoryById(parking.VehicleCategory);

            DateTime now = DateTime.Now;
            parking.FinalizedAt = now;

            var difference = now.Subtract(parking.StartedAt);

            var minutes = difference.Minutes;
            var hours = difference.Hours;
            lbl_permanenceTime.Text = $"{hours} hora(s) {minutes} minuto(s)";

            var totalValue = 0.0;
            if (hours == 0)
            {
                totalValue = 1 * vehicleCategory.Value;
            } else if (minutes <= vehicleCategory.Tolerance)
            {
                totalValue = hours * vehicleCategory.Value;
            } else
            {
                totalValue = (hours + 1) * vehicleCategory.Value;
            }

            parking.TotalValue = totalValue;
            
            lbl_value.Text = totalValue.ToString("n2");
            tbx_valueReceived.Text = totalValue.ToString("n2");
        }

        private void FinishParking_Load(object sender, System.EventArgs e)
        {
            CalculeParkingPermanenceTimeAndValues();

            lbl_plateDescription.Text = parking.Plate;
            lbl_idParkingDescription.Text = parking.Code.ToString();
            lbl_modelDescription.Text = vehicleModel.LoadVehicleModelById(parking.VehicleModel).Model;
            lbl_categoryDescription.Text = vehicleCategory.LoadCategoryById(parking.VehicleCategory).Category;
            lbl_colorDescription.Text = vehicleColor.LoadColorById(parking.VehicleColor).Color;
            lbl_startDescription.Text = parking.StartedAt.ToString("HH:mm");

            lbl_finishDescription.Text = parking.FinalizedAt.ToString("HH:mm");

            tbx_valueReceived.Focus();
        }

        private void btn_cancelParking_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private bool isValidFinalization()
        {
            double discount = 0.0;
            double increase = 0.0;
            double valueReceived = 0.0;
            double value = 0.0;
            double overplus = 0.0;

            if (String.IsNullOrWhiteSpace(tbx_discount.Text) == false &&
                Convert.ToDouble(tbx_discount.Text) > 0)
                discount = Convert.ToDouble(tbx_discount.Text);
            if (String.IsNullOrWhiteSpace(tbx_increase.Text) == false &&
                Convert.ToDouble(tbx_increase.Text) > 0)
                increase = Convert.ToDouble(tbx_increase.Text);
            if (String.IsNullOrWhiteSpace(tbx_valueReceived.Text) == false &&
                Convert.ToDouble(tbx_valueReceived.Text) > 0)
                valueReceived = Convert.ToDouble(tbx_valueReceived.Text);
            if (String.IsNullOrWhiteSpace(lbl_value.Text) == false &&
                Convert.ToDouble(lbl_value.Text) > 0)
                value = Convert.ToDouble(lbl_value.Text);
            if (String.IsNullOrWhiteSpace(tbx_overplus.Text) == false &&
                    Convert.ToDouble(tbx_overplus.Text) > 0)
                overplus = Convert.ToDouble(tbx_overplus.Text);

            if (valueReceived < value)
            {
                MessageBox.Show("Total a ser cobrado é maior do que o valor recebido");
                return false;
            }

            parking.Increase = increase;
            parking.Discount = discount;
            parking.TotalValue = value;
            return true;

        }

        private void CalculeCurrentValues()
        {
            double discount = 0.0;
            double increase = 0.0;
            double valueReceived = 0.0;
            double value = 0.0;
            double overplus = 0.0;

            if (String.IsNullOrWhiteSpace(tbx_discount.Text) == false &&
                Convert.ToDouble(tbx_discount.Text) > 0.0)
                discount = Convert.ToDouble(tbx_discount.Text);
            if (String.IsNullOrWhiteSpace(tbx_increase.Text) == false &&
                Convert.ToDouble(tbx_increase.Text) > 0.0)
                increase = Convert.ToDouble(tbx_increase.Text);
            if (String.IsNullOrWhiteSpace(tbx_valueReceived.Text) == false &&
                Convert.ToDouble(tbx_valueReceived.Text) > 0.0)
                valueReceived = Convert.ToDouble(tbx_valueReceived.Text);
            if (String.IsNullOrWhiteSpace(tbx_valueReceived.Text) == false &&
                Convert.ToDouble(tbx_valueReceived.Text) > 0.0)
                valueReceived = Convert.ToDouble(tbx_valueReceived.Text);

            value = parking.TotalValue + increase - discount;
            overplus = valueReceived - value;
            lbl_value.Text = value.ToString("n2");
            tbx_overplus.Text = overplus.ToString("n2");
        }

        private void btn_finishParking_Click(object sender, EventArgs e)
        {
            if (isValidFinalization() == false)
            {
                return;
            }
            CalculeCurrentValues();
            parking.Status = "FINALIZADO";
            if (parking.UpdateParking(parking))
            {
                Close();
            }
            else
                MessageBox.Show("ERRO: Problema ao executar operação no banco de dados");

        }

        private void FinishParking_Enter(object sender, EventArgs e)
        {
            btn_finishParking_Click(sender, e);
        }

        private void tbx_discount_TextChanged(object sender, EventArgs e)
        {
            CalculeCurrentValues();
        }

        private void tbx_increase_TextChanged(object sender, EventArgs e)
        {
            CalculeCurrentValues();
        }

        private void tbx_valueReceived_TextChanged(object sender, EventArgs e)
        {
            CalculeCurrentValues();
        }

        private void btn_finishParking_Enter(object sender, EventArgs e)
        {
            btn_finishParking.BackColor = System.Drawing.Color.Red;
        }

        private void btn_finishParking_Leave(object sender, EventArgs e)
        {
            btn_finishParking.BackColor = System.Drawing.Color.FromArgb(0, 112, 204);
        }

        private void btn_cancelParking_Enter(object sender, EventArgs e)
        {
            btn_cancelParking.BackColor = System.Drawing.Color.Red;
        }

        private void btn_cancelParking_Leave(object sender, EventArgs e)
        {
            btn_cancelParking.BackColor = System.Drawing.Color.FromArgb(110, 170, 250);
        }
    }
}
