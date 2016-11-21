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
    public partial class Area : UserControl
    {
        public Area()
        {
            InitializeComponent();
            int index = cmbAreaUnit.FindString("meter²  (m²)");
            cmbAreaUnit.SelectedIndex = index;
            Calculation();
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtArea.Text);
            if (isValid)
            {
                double area = double.Parse(txtArea.Text);
                AreaConverter(area, cmbAreaUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void AreaConverter(double value, string units)
        {
            switch (units)
            {
                case "meter²  (m²)":
                    txtSqM.Text = value.ToString();
                    txtSqMm.Text = (value * 1000000).ToString();
                    txtSqCm.Text = (value * 10000).ToString();
                    txtSqIn.Text = (value * 1550).ToString();
                    txtSqKm.Text = (value * 0.000001).ToString();
                    txtSqYd.Text = (value * 1.1960).ToString();
                    txtSqFt.Text = (value * 10.764).ToString();
                    txtSqAcre.Text = (value * 0.00024711).ToString();
                    break;
                case "millimeter²  (mm²)":
                    txtSqM.Text = (value * 0.000001).ToString();
                    txtSqMm.Text = value.ToString();
                    txtSqCm.Text = (value * 0.01).ToString();
                    txtSqIn.Text = (value * 0.00155).ToString();
                    txtSqKm.Text = (value * 0.000000000001).ToString();
                    txtSqYd.Text = (value * 0.000001196).ToString();
                    txtSqFt.Text = (value * 0.000010764).ToString();
                    txtSqAcre.Text = (value * 0.00000000024711).ToString();
                    break;
                case "centimeter²  (cm²)":
                    txtSqM.Text = (value * 0.0001).ToString();
                    txtSqMm.Text = (value * 100).ToString();
                    txtSqCm.Text = value.ToString();
                    txtSqIn.Text = (value * 0.1550).ToString();
                    txtSqKm.Text = (value * 0.0000000001).ToString();
                    txtSqYd.Text = (value * 0.0001196).ToString();
                    txtSqFt.Text = (value * 0.0010764).ToString();
                    txtSqAcre.Text = (value * 0.000000024711).ToString();
                    break;
                case "kilometer²  (km²)":
                    txtSqM.Text = (value * 1000000).ToString();
                    txtSqMm.Text = (value * 1000000000000).ToString();
                    txtSqCm.Text = (value * 10000000000).ToString();
                    txtSqIn.Text = (value * 1550000000).ToString();
                    txtSqKm.Text = value.ToString();
                    txtSqYd.Text = (value * 1196000).ToString();
                    txtSqFt.Text = (value * 10764000).ToString();
                    txtSqAcre.Text = (value * 247.11).ToString();
                    break;
                case "inch²  (in²)":
                    txtSqM.Text = (value * 0.00064516).ToString();
                    txtSqMm.Text = (value * 645.16).ToString();
                    txtSqCm.Text = (value * 6.4516).ToString();
                    txtSqIn.Text = value.ToString();
                    txtSqKm.Text = (value * 0.00000000064516).ToString();
                    txtSqYd.Text = (value * 0.00077160).ToString();
                    txtSqFt.Text = (value * 0.0069444).ToString();
                    txtSqAcre.Text = (value * 0.000000159422508).ToString();
                    break;
                case "foot²  (ft²)":
                    txtSqM.Text = (value * 0.092903).ToString();
                    txtSqMm.Text = (value * 0.092903 * 1000000).ToString();
                    txtSqCm.Text = (value * 0.092903 * 10000).ToString();
                    txtSqIn.Text = (value * 144).ToString();
                    txtSqKm.Text = (value * 0.092903 * 0.000001).ToString();
                    txtSqYd.Text = (value * 0.1111111).ToString();
                    txtSqFt.Text = value.ToString();
                    txtSqAcre.Text = (value * 0.000022957).ToString();
                    break;
                case "yard²  (yd²)":
                    txtSqM.Text = (value / 1.1960).ToString();
                    txtSqMm.Text = (value / 1.1960 * 1000000).ToString();
                    txtSqCm.Text = (value / 1.1960 * 10000).ToString();
                    txtSqIn.Text = (value * 1296).ToString();
                    txtSqKm.Text = (value / 1.1960 * 0.000001).ToString();
                    txtSqYd.Text = value.ToString();
                    txtSqFt.Text = (value * 9).ToString();
                    txtSqAcre.Text = (value * 0.0002066).ToString();
                    break;
                case "acre":
                    txtSqM.Text = (value / 0.00024711).ToString();
                    txtSqMm.Text = (value / 0.00024711 * 1000000).ToString();
                    txtSqCm.Text = (value / 0.00024711 * 10000).ToString();
                    txtSqIn.Text = (value * 6272600).ToString();
                    txtSqKm.Text = (value / 0.00024711 * 0.000001).ToString();
                    txtSqYd.Text = (value * 4840).ToString();
                    txtSqFt.Text = (value * 43560).ToString();
                    txtSqAcre.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtSqM.Clear();
            txtSqAcre.Clear();
            txtSqCm.Clear();
            txtSqFt.Clear();
            txtSqIn.Clear();
            txtSqKm.Clear();
            txtSqMm.Clear();
            txtSqYd.Clear();
        }

        private void cmbAreaUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }
    }
}
