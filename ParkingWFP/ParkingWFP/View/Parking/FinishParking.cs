/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Model;
using System;
using System.Windows.Forms;

namespace ParkingWFP.View
{
    public partial class FinishParking : Form
    {

        public Parking parking = new Parking();
        VehicleCategory vehicleCategory = new VehicleCategory();


        public FinishParking()
        {
            InitializeComponent();
        }


        private void CheckKeyPress(KeyPressEventArgs e)
        {
            int backspace = 8;
            int comman = 44;
            char key = e.KeyChar;

            if (key == comman && tbx_value.Text.IndexOf('.') != -1)
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

        private double CalculeParkingValue(DateTime now)
        {
            double hours = Math.Ceiling((now - parking.StartedAt).TotalHours);
            return hours * vehicleCategory.Value;
        }

        private void FinishParking_Load(object sender, System.EventArgs e)
        {
            vehicleCategory = vehicleCategory.LoadCategoryById(parking.VehicleCategory);
            DateTime now = DateTime.Now;

            tbx_plateDescription.Text = parking.Plate;
            tbx_idParkingDescription.Text = parking.IdParking.ToString();
            tbx_startDescription.Text = parking.StartedAt.ToString();

            parking.FinalizedAt = now;
            tbx_finishDescription.Text = parking.FinalizedAt.ToString();
            
            tbx_permanenceTime.Text = now.Subtract(parking.StartedAt).ToString();

            parking.TotalValue = CalculeParkingValue(now);

            tbx_value.Text = parking.TotalValue.ToString();
            tbx_valueReceived.Text = parking.TotalValue.ToString();
        }

        private void btn_cancelParking_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private bool isValidFinalization()
        {
            double value = Convert.ToDouble(tbx_value.Text);
            double discount = Convert.ToDouble(tbx_discount.Text);
            double valueReceived = Convert.ToDouble(tbx_valueReceived.Text);
            double overplus = Convert.ToDouble(tbx_overplus.Text);

            if (valueReceived < value)
            {
                MessageBox.Show("Valor é maior do que valor recebido");
                return false;
            }

            if (discount > value)
            {
                MessageBox.Show("O desconto é maior do que o valor");
                return false;
            }

            if (overplus < 0)
            {
                MessageBox.Show("O troco não pode ser negativo");
                return false;
            }

            return true;

        }

        private double CalculeCurrentTotalValue()
        {
            if (string.IsNullOrWhiteSpace(tbx_discount.Text))
            {
                tbx_discount.Text = "0,00";
            }
            if (string.IsNullOrWhiteSpace(tbx_increase.Text))
            {
                tbx_increase.Text = "0,00";
            }

            double discount = Convert.ToDouble(tbx_discount.Text);
            double increase = Convert.ToDouble(tbx_increase.Text);
            return parking.TotalValue + increase - discount;
        }

        private void btn_finishParking_Click(object sender, EventArgs e)
        {
            if (isValidFinalization() == false)
            {
                return;
            }
            parking.Increase = Convert.ToDouble(tbx_increase.Text);
            parking.Discount = Convert.ToDouble(tbx_discount.Text);
            parking.TotalValue = CalculeCurrentTotalValue();
            parking.FinalizedAt = DateTime.Now;
            parking.Status = "Finalizado";
            if (parking.UpdateParking(parking))
            {
                MessageBox.Show("Operação concluida, imprimindo comprovante");
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
            tbx_value.Text = CalculeCurrentTotalValue().ToString();
        }

        private void tbx_increase_TextChanged(object sender, EventArgs e)
        {
            tbx_value.Text = CalculeCurrentTotalValue().ToString();
        }

        private void tbx_value_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_value.Text))
            {
                tbx_value.Text = "0,00";
            }

            double value = Convert.ToDouble(tbx_value.Text);
            double valueReceived = Convert.ToDouble(tbx_valueReceived.Text);
            tbx_overplus.Text = (valueReceived - value).ToString();
        }

        private void tbx_valueReceived_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_valueReceived.Text))
            {
                tbx_valueReceived.Text = "0,00";
            }

            double value = Convert.ToDouble(tbx_value.Text);
            double valueReceived = Convert.ToDouble(tbx_valueReceived.Text);
            tbx_overplus.Text = (valueReceived - value).ToString();
        }
    }
}
