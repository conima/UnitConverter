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
    public partial class Pressure : UserControl
    {
        public Pressure()
        {
            InitializeComponent();
            int index = cmbPressureUnit.FindString("atmosphere (atm)");
            cmbPressureUnit.SelectedIndex = index;
            Calculation();
        }

        private void txtPressure_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void cmbPressureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtPressure.Text);
            if (isValid)
            {
                double pressure = double.Parse(txtPressure.Text);
                PressureConverter(pressure, cmbPressureUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void PressureConverter(double value, string units)
        {
            switch (units)
            {
                case "atmosphere (atm)":
                    txtAtm.Text = value.ToString();
                    txtPsi.Text = Math.Round((value * 14.6959488), 4).ToString();
                    txtPascal.Text = Math.Round((value * 101325), 4).ToString();
                    txtBar.Text = Math.Round((value * 1.01325), 4).ToString();
                    break;
                case "psi":
                    txtAtm.Text = Math.Round((value / 14.6959488), 4).ToString();
                    txtPsi.Text = value.ToString();
                    txtPascal.Text = Math.Round((value * 101325 / 14.6959488), 4).ToString();
                    txtBar.Text = Math.Round((value * 1.01325 / 14.6959488), 4).ToString();
                    break;
                case "pascal  (Pa)":
                    txtAtm.Text = Math.Round((value / 101325), 7).ToString();
                    txtPsi.Text = Math.Round((value * 14.6959488 / 101325), 7).ToString();
                    txtPascal.Text = value.ToString();
                    txtBar.Text = Math.Round((value * 1.01325 / 101325), 7).ToString();
                    break;
                case "bar":
                    txtAtm.Text = Math.Round((value / 1.01325), 4).ToString();
                    txtPsi.Text = Math.Round((value * 14.6959488 / 1.01325), 4).ToString();
                    txtPascal.Text = Math.Round((value * 101325 / 1.01325), 4).ToString();
                    txtBar.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtAtm.Clear();
            txtPsi.Clear();
            txtPascal.Clear();
            txtBar.Clear();
        }
    }
}
