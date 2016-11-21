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
    public partial class Fuel : UserControl
    {
        public Fuel()
        {
            InitializeComponent();
            int index = cmbFuelUnit.FindString("liter/100 km");
            cmbFuelUnit.SelectedIndex = index;
            Calculation();
        }

        private void cmbFuelUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtFuel_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtFuel.Text);
            if (isValid)
            {
                double fuel = double.Parse(txtFuel.Text);
                FuelConverter(fuel, cmbFuelUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void FuelConverter(double value, string units)
        {
            switch (units)
            {
                case "kilometer/liter (km/l)":
                    txtKmL.Text = value.ToString();
                    txtMiL.Text = Math.Round((value * 0.621371192), 4).ToString();
                    txtL100.Text = Math.Round((100 / value), 4).ToString();
                    txtGal100.Text = Math.Round((100 / value * 0.4251437075), 4).ToString();
                    txtKmGal.Text = Math.Round((value * 3.785411783), 4).ToString();
                    txtMiGal.Text = Math.Round((value * 2.352145833), 4).ToString();
                    break;
                case "mile/liter  (mi/l)":
                    txtKmL.Text = Math.Round((value * 1.609344), 4).ToString();
                    txtMiL.Text = value.ToString();
                    txtL100.Text = Math.Round((100 / (value / 0.621371192)), 4).ToString();
                    txtGal100.Text = Math.Round((100 / (value * 1.609344) * 0.4251437075), 4).ToString();
                    txtKmGal.Text = Math.Round((value / 0.621371192 * 3.785411783), 4).ToString();
                    txtMiGal.Text = Math.Round((value / 0.621371192 * 2.352145833), 4).ToString();
                    break;
                case "liter/100 km":
                    txtKmL.Text = Math.Round((100 / value), 4).ToString();
                    txtMiL.Text = Math.Round((100 / value * 0.621371192), 4).ToString();
                    txtL100.Text = value.ToString();
                    txtGal100.Text = Math.Round((value / 100 * 42.51437075), 4).ToString();
                    txtKmGal.Text = Math.Round((100 / value * 3.785411783), 4).ToString();
                    txtMiGal.Text = Math.Round((100 / value * 2.352145833), 4).ToString();
                    break;
                case "gallons/100 mi":
                    txtKmL.Text = Math.Round((100 / (value * 2.352145833)), 4).ToString();
                    txtMiL.Text = Math.Round((100 / (value * 2.352145833) * 0.621371192), 4).ToString();
                    txtL100.Text = Math.Round((value * 2.352145833), 4).ToString();
                    txtGal100.Text = value.ToString();
                    txtKmGal.Text = Math.Round((100 / (value * 2.352145833) * 3.785411783), 4).ToString();
                    txtMiGal.Text = Math.Round((100 / value), 4).ToString();
                    break;
                case "kilometer/gallon  (km/gal)":
                    txtKmL.Text = Math.Round((value / 3.785411783), 4).ToString();
                    txtMiL.Text = Math.Round((value / 3.785411783 * 0.621371192), 4).ToString();
                    txtL100.Text = Math.Round((100 / (value / 3.785411783)), 4).ToString();
                    txtGal100.Text = Math.Round((100 / (value / 3.785411783) * 0.4251437075), 4).ToString();
                    txtKmGal.Text = value.ToString();
                    txtMiGal.Text = Math.Round((value / 3.785411783 * 2.352145833), 4).ToString();
                    break;
                case "mile per gallon  (mpg)":
                    txtKmL.Text = Math.Round((value * 0.4251437075), 4).ToString();
                    txtMiL.Text = Math.Round((value * 0.2641720524), 4).ToString();
                    txtL100.Text = Math.Round((100 / (value * 0.4251437075)), 4).ToString();
                    txtGal100.Text = Math.Round((100 / value), 4).ToString();
                    txtKmGal.Text = Math.Round((value * 1.609344), 4).ToString();
                    txtMiGal.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtKmL.Clear();
            txtMiL.Clear();
            txtL100.Clear();
            txtGal100.Clear();
            txtKmGal.Clear();
            txtMiGal.Clear();
        }
    }
}
