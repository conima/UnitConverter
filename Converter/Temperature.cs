using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converter.Common;

namespace Converter
{
    public partial class Temperature : UserControl
    {
        public Temperature()
        {
            InitializeComponent();
            int index = cmbTempUnit.FindString("Celsius (C°)");
            cmbTempUnit.SelectedIndex = index;
            Calculation();
        }

        private void txtTemperature_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void cmbTempUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtTemperature.Text);
            if (isValid)
            {
                double temperature = double.Parse(txtTemperature.Text);
                TemperatureConverter(temperature, cmbTempUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void TemperatureConverter(double value, string units)
        {
            switch (units)
            {
                case "Celsius (C°)":
                    txtCelsius.Text = value.ToString();
                    txtFahrenheit.Text = Math.Round(((value * 1.8) + 32), 4).ToString();
                    txtKelvin.Text = (value + 273.15).ToString();
                    break;
                case "Fahrenheit  (F°)":
                    txtCelsius.Text = Math.Round((((value - 32) * 5) / 9), 4).ToString();
                    txtFahrenheit.Text = value.ToString();
                    txtKelvin.Text = Math.Round(((((value - 32) * 5) / 9) + 273.15), 4).ToString();
                    break;
                case "Kelvin  (K)":
                    txtCelsius.Text = (value - 273.15).ToString();
                    txtFahrenheit.Text = Math.Round((((value - 273.15) * 1.8) + 32), 4).ToString();
                    txtKelvin.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtCelsius.Clear();
            txtFahrenheit.Clear();
            txtKelvin.Clear();           
        }
    }
}
