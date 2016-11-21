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
    public partial class Length : UserControl
    {
        public Length()
        {
            InitializeComponent();
            int index = cmbLengthUnit.FindString("meter (m)");
            cmbLengthUnit.SelectedIndex = index;
            Calculation();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void cmbLengthUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtLength.Text);
            if (isValid)
            {
                double length = double.Parse(txtLength.Text);
                LengthConverter(length, cmbLengthUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void LengthConverter(double value, string units)
        {
            switch (units)
            {
                case "meter (m)":
                    txtM.Text = value.ToString();
                    txtMm.Text = (value * 1000).ToString();
                    txtCm.Text = (value * 100).ToString();
                    txtIn.Text = (value * 39.37).ToString();
                    txtKm.Text = (value * 0.001).ToString();
                    txtYd.Text = (value * 1.0936).ToString();
                    txtFt.Text = (value * 3.2808).ToString();
                    txtMile.Text = (value * 0.00062137).ToString();
                    break;
                case "millimeter  (mm)":
                    txtM.Text = (value * 0.001).ToString();
                    txtMm.Text = value.ToString();
                    txtCm.Text = (value * 0.1).ToString();
                    txtIn.Text = (value * 39.37 * 0.001).ToString();
                    txtKm.Text = (value * 0.000001).ToString();
                    txtYd.Text = (value * 1.0936 * 0.001).ToString();
                    txtFt.Text = (value * 3.2808 * 0.001).ToString();
                    txtMile.Text = (value * 0.00062137 * 0.001).ToString();
                    break;
                case "centimeter  (cm)":
                    txtM.Text = (value * 0.01).ToString();
                    txtMm.Text = (value * 10).ToString();
                    txtCm.Text = value.ToString();
                    txtIn.Text = (value * 39.37 * 0.01).ToString();
                    txtKm.Text = (value * 0.00001).ToString();
                    txtYd.Text = (value * 1.0936 * 0.01).ToString();
                    txtFt.Text = (value * 3.2808 * 0.01).ToString();
                    txtMile.Text = (value * 0.00062137 * 0.01).ToString();
                    break;
                case "kilometer  (km)":
                    txtM.Text = (value * 1000).ToString();
                    txtMm.Text = (value * 1000000).ToString();
                    txtCm.Text = (value * 100000).ToString();
                    txtIn.Text = (value * 39.37 * 1000).ToString();
                    txtKm.Text = value.ToString();
                    txtYd.Text = (value * 1.0936 * 1000).ToString();
                    txtFt.Text = (value * 3.2808 * 1000).ToString();
                    txtMile.Text = (value * 0.00062137 * 1000).ToString();
                    break;
                case "inch  (in)":
                    txtM.Text = Math.Round((value / 39.370), 4).ToString();
                    txtMm.Text = Math.Round((value / 39.370 * 1000), 4).ToString();
                    txtCm.Text = Math.Round((value / 39.370 * 100), 4).ToString();
                    txtIn.Text = value.ToString();
                    txtKm.Text = (value / 39.370 * 0.001).ToString();
                    txtYd.Text = Math.Round((value * 0.027778), 4).ToString();
                    txtFt.Text = Math.Round((value * 0.083333), 4).ToString();
                    txtMile.Text = Math.Round((value / 63360), 4).ToString();
                    break;
                case "foot  (ft)":
                    txtM.Text = (value * 0.3048).ToString();
                    txtMm.Text = (value * 0.3048 * 1000).ToString();
                    txtCm.Text = (value * 0.3048 * 100).ToString();
                    txtIn.Text = (value * 12).ToString();
                    txtKm.Text = (value * 0.3048 * 0.001).ToString();
                    txtYd.Text = Math.Round((value / 3), 4).ToString();
                    txtFt.Text = value.ToString();
                    txtMile.Text = Math.Round((value / 5280), 6).ToString();
                    break;
                case "yard  (yd)":
                    txtM.Text = (value * 0.9144).ToString();
                    txtMm.Text = (value * 0.9144 * 1000).ToString();
                    txtCm.Text = (value * 0.9144 * 100).ToString();
                    txtIn.Text = (value * 36).ToString();
                    txtKm.Text = (value * 0.9144 * 0.001).ToString();
                    txtYd.Text = value.ToString();
                    txtFt.Text = (value * 3).ToString();
                    txtMile.Text = Math.Round((value / 1760), 6).ToString();
                    break;
                case "mile":
                    txtM.Text = (value * 1609.344).ToString();
                    txtMm.Text = (value * 1609.344 * 1000).ToString();
                    txtCm.Text = (value * 1609.344 * 100).ToString();
                    txtIn.Text = (value * 63360).ToString();
                    txtKm.Text = (value * 1609.344 * 0.001).ToString();
                    txtYd.Text = (value * 1760).ToString();
                    txtFt.Text = (value * 5280).ToString();
                    txtMile.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtM.Clear();
            txtMm.Clear();
            txtCm.Clear();
            txtIn.Clear();
            txtKm.Clear();
            txtYd.Clear();
            txtFt.Clear();
            txtMile.Clear();
        }
    }
}
