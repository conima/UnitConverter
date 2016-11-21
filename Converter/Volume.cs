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
    public partial class Volume : UserControl
    {
        public Volume()
        {
            InitializeComponent();
            int index = cmbVolumeUnit.FindString("meter³ (m³)");
            cmbVolumeUnit.SelectedIndex = index;
            Calculation();
        }

        private void cmbVolumeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtVolume.Text);
            if (isValid)
            {
                double volume = double.Parse(txtVolume.Text);
                VolumeConverter(volume, cmbVolumeUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void VolumeConverter(double value, string units)
        {
            switch (units)
            {
                case "meter³ (m³)":
                    txtCuM.Text = value.ToString();
                    txtCuCm.Text = (value * 1000000).ToString();
                    txtLiter.Text = (value / 0.001).ToString();
                    txtDekaliter.Text = (value * 100).ToString();
                    txtMliter.Text = (value / 0.000001).ToString();
                    txtCc.Text = (value * 1000000).ToString();
                    txtGal.Text = Math.Round((value / 0.001 / 3.785411784), 4).ToString();
                    txtQuart.Text = Math.Round((value / 0.001 / 0.94635294599999995904), 4).ToString();
                    txtPint.Text = Math.Round((value / 0.001 / 0.47317647299999997952), 4).ToString();
                    txtCup.Text = Math.Round((value / 0.001 / 0.23658823649999998976), 4).ToString();
                    txtOunce.Text = Math.Round((value / 0.001 / 0.029573529562499997696), 4).ToString();
                    txtTbsp.Text = Math.Round((value / 0.001 / 0.014786764781249998848), 4).ToString();
                    txtTsp.Text = Math.Round((value / 0.001 / 0.004928921593749999616), 4).ToString();
                    break;
                case "centimeter³  (cm³)":
                    txtCuM.Text = (value / 1000000).ToString();
                    txtCuCm.Text = value.ToString();
                    txtLiter.Text = (value / 1000).ToString();
                    txtDekaliter.Text = (value / 10000).ToString();
                    txtMliter.Text = value.ToString();
                    txtCc.Text = value.ToString();
                    txtGal.Text = Math.Round((value * 0.001 / 3.785411784), 4).ToString();
                    txtQuart.Text = Math.Round((value / 0.001 / 1000000 / 0.94635294599999995904), 4).ToString();
                    txtPint.Text = Math.Round((value / 0.001 / 1000000 / 0.47317647299999997952), 4).ToString();
                    txtCup.Text = Math.Round((value / 0.001 / 1000000 / 0.23658823649999998976), 4).ToString();
                    txtOunce.Text = Math.Round((value / 0.001 / 1000000 / 0.029573529562499997696), 4).ToString();
                    txtTbsp.Text = Math.Round((value / 0.001 / 1000000 / 0.014786764781249998848), 4).ToString();
                    txtTsp.Text = Math.Round((value / 0.001 / 1000000 / 0.004928921593749999616), 4).ToString();
                    break;
                case "liter  (l)":
                    txtCuM.Text = (value * 0.001).ToString();
                    txtCuCm.Text = (value / 0.001).ToString();
                    txtLiter.Text = value.ToString();
                    txtDekaliter.Text = (value / 10).ToString();
                    txtMliter.Text = (value / 0.001).ToString();
                    txtCc.Text = (value / 0.001).ToString();
                    txtGal.Text = Math.Round((value / 3.785411784), 4).ToString();
                    txtQuart.Text = Math.Round((value / 0.94635294599999995904), 4).ToString();
                    txtPint.Text = Math.Round((value / 0.47317647299999997952), 4).ToString();
                    txtCup.Text = Math.Round((value / 0.23658823649999998976), 4).ToString();
                    txtOunce.Text = Math.Round((value / 0.029573529562499997696), 4).ToString();
                    txtTbsp.Text = Math.Round((value / 0.014786764781249998848), 4).ToString();
                    txtTsp.Text = Math.Round((value / 0.004928921593749999616), 4).ToString();
                    break;
                case "dekaliter  (dal)":
                    txtCuM.Text = (value * 0.01).ToString();
                    txtCuCm.Text = (value * 10000).ToString();
                    txtLiter.Text = (value * 10).ToString();
                    txtDekaliter.Text = value.ToString();
                    txtMliter.Text = (value * 10000).ToString();
                    txtCc.Text = (value * 10000).ToString();
                    txtGal.Text = Math.Round((value *10 / 3.785411784), 4).ToString();
                    txtQuart.Text = Math.Round((value * 10 / 0.94635294599999995904), 4).ToString();
                    txtPint.Text = Math.Round((value * 10 / 0.47317647299999997952), 4).ToString();
                    txtCup.Text = Math.Round((value * 10 / 0.23658823649999998976), 4).ToString();
                    txtOunce.Text = Math.Round((value * 10 / 0.029573529562499997696), 4).ToString();
                    txtTbsp.Text = Math.Round((value * 10 / 0.014786764781249998848), 4).ToString();
                    txtTsp.Text = Math.Round((value * 10 / 0.004928921593749999616), 4).ToString();
                    break;
                case "milliliter  (ml)":
                    txtCuM.Text = (value / 1000000).ToString();
                    txtCuCm.Text = value.ToString();
                    txtLiter.Text = (value / 1000).ToString();
                    txtDekaliter.Text = (value / 10000).ToString();
                    txtMliter.Text = value.ToString();
                    txtCc.Text = value.ToString();
                    txtGal.Text = Math.Round((value / 1000 / 3.785411784), 4).ToString();
                    txtQuart.Text = Math.Round((value / 1000 / 0.94635294599999995904), 6).ToString();
                    txtPint.Text = Math.Round((value / 1000 / 0.47317647299999997952), 6).ToString();
                    txtCup.Text = Math.Round((value / 1000 / 0.23658823649999998976), 6).ToString();
                    txtOunce.Text = Math.Round((value / 1000 / 0.029573529562499997696), 6).ToString();
                    txtTbsp.Text = Math.Round((value / 1000 / 0.014786764781249998848), 6).ToString();
                    txtTsp.Text = Math.Round((value / 1000 / 0.004928921593749999616), 6).ToString();
                    break;
                case "cc  (cc)":
                    txtCuM.Text = (value / 1000000).ToString();
                    txtCuCm.Text = value.ToString();
                    txtLiter.Text = (value / 1000).ToString();
                    txtDekaliter.Text = (value / 10000).ToString();
                    txtMliter.Text = value.ToString();
                    txtCc.Text = value.ToString();
                    txtGal.Text = Math.Round((value / 1000 / 3.785411784), 4).ToString();
                    txtQuart.Text = Math.Round((value / 1000 / 0.94635294599999995904), 6).ToString();
                    txtPint.Text = Math.Round((value / 1000 / 0.47317647299999997952), 6).ToString();
                    txtCup.Text = Math.Round((value / 1000 / 0.23658823649999998976), 6).ToString();
                    txtOunce.Text = Math.Round((value / 1000 / 0.029573529562499997696), 6).ToString();
                    txtTbsp.Text = Math.Round((value / 1000 / 0.014786764781249998848), 6).ToString();
                    txtTsp.Text = Math.Round((value / 1000 / 0.004928921593749999616), 6).ToString();
                    break;
                case "gallon  (gal)":
                    txtCuM.Text = (value / 264.17).ToString();
                    txtCuCm.Text =  (value / 264.17 * 1000000).ToString();
                    txtLiter.Text = (value/ 0.26417).ToString();
                    txtDekaliter.Text = (value / 10 / 0.26417).ToString();
                    txtMliter.Text = (value / 0.001 / 0.26417).ToString();
                    txtCc.Text = (value / 0.001 / 0.26417).ToString();
                    txtGal.Text = value.ToString();
                    txtQuart.Text = (value * 4).ToString();
                    txtPint.Text = (value * 8).ToString();
                    txtCup.Text = (value * 16).ToString();
                    txtOunce.Text = (value * 128).ToString();
                    txtTbsp.Text = (value * 256).ToString();
                    txtTsp.Text = (value * 768).ToString();
                    break;
                case "quart  (qt)":
                    txtCuM.Text = (value / 264.17 / 4).ToString();
                    txtCuCm.Text = (value / 264.17 * 1000000 / 4).ToString();
                    txtLiter.Text = (value / 0.26417 / 4).ToString();
                    txtDekaliter.Text = (value / 10 / 0.26417 / 4).ToString();
                    txtMliter.Text = (value / 0.001 / 0.26417 / 4).ToString();
                    txtCc.Text = (value / 0.001 / 0.26417 / 4).ToString();
                    txtGal.Text = (value / 4).ToString();
                    txtQuart.Text = value.ToString();
                    txtPint.Text = (value * 2).ToString();
                    txtCup.Text = (value * 4).ToString();
                    txtOunce.Text = (value * 32).ToString();
                    txtTbsp.Text = (value * 64).ToString();
                    txtTsp.Text = (value * 192).ToString();
                    break;
                case "pint  (pt)":
                    txtCuM.Text = Math.Round((value / 264.17 / 8), 7).ToString();
                    txtCuCm.Text = Math.Round((value / 264.17 * 1000000 / 8), 4).ToString();
                    txtLiter.Text = Math.Round((value / 0.26417 / 8), 4).ToString();
                    txtDekaliter.Text = Math.Round((value / 10 / 0.26417 / 8), 4).ToString();
                    txtMliter.Text = Math.Round((value / 0.001 / 0.26417 / 8), 4).ToString();
                    txtCc.Text = Math.Round((value / 0.001 / 0.26417 / 8), 4).ToString();
                    txtGal.Text = (value / 8).ToString();
                    txtQuart.Text = (value / 2).ToString();
                    txtPint.Text = value.ToString();
                    txtCup.Text = (value * 2).ToString();
                    txtOunce.Text = (value * 16).ToString();
                    txtTbsp.Text = (value * 32).ToString();
                    txtTsp.Text = (value * 96).ToString();
                    break;
                case "cup":
                    txtCuM.Text = Math.Round((value / 264.17 / 16), 7).ToString();
                    txtCuCm.Text = Math.Round((value / 264.17 * 1000000 / 16), 4).ToString();
                    txtLiter.Text = Math.Round((value / 0.26417 / 16), 4).ToString();
                    txtDekaliter.Text = Math.Round((value / 10 / 0.26417 / 16), 4).ToString();
                    txtMliter.Text = Math.Round((value / 0.001 / 0.26417 / 16), 4).ToString();
                    txtCc.Text = Math.Round((value / 0.001 / 0.26417 / 16), 4).ToString();
                    txtGal.Text = (value / 16).ToString();
                    txtQuart.Text = (value / 4).ToString();
                    txtPint.Text = (value / 2).ToString();
                    txtCup.Text = value.ToString();
                    txtOunce.Text = (value * 8).ToString();
                    txtTbsp.Text = (value * 16).ToString();
                    txtTsp.Text = (value * 48).ToString();
                    break;
                case "ounce  (fl oz)":
                    txtCuM.Text = Math.Round((value / 264.17 / 128), 7).ToString();
                    txtCuCm.Text = Math.Round((value / 264.17 * 1000000 / 128), 4).ToString();
                    txtLiter.Text = Math.Round((value / 0.26417 / 128), 4).ToString();
                    txtDekaliter.Text = Math.Round((value / 10 / 0.26417 / 128), 6).ToString();
                    txtMliter.Text = Math.Round((value / 0.001 / 0.26417 / 128), 4).ToString();
                    txtCc.Text = Math.Round((value / 0.001 / 0.26417 / 128), 4).ToString();
                    txtGal.Text = (value / 128).ToString();
                    txtQuart.Text = (value / 32).ToString();
                    txtPint.Text = (value / 16).ToString();
                    txtCup.Text = (value / 8).ToString();
                    txtOunce.Text = value.ToString();
                    txtTbsp.Text = (value * 2).ToString();
                    txtTsp.Text = (value * 6).ToString();
                    break;
                case "tablespoon  (tbsp)":
                    txtCuM.Text = Math.Round((value / 264.17 / 256), 7).ToString();
                    txtCuCm.Text = Math.Round((value / 264.17 * 1000000 / 256), 4).ToString();
                    txtLiter.Text = Math.Round((value / 0.26417 / 256), 4).ToString();
                    txtDekaliter.Text = Math.Round((value / 10 / 0.26417 / 256), 6).ToString();
                    txtMliter.Text = Math.Round((value / 0.001 / 0.26417 / 256), 4).ToString();
                    txtCc.Text = Math.Round((value / 0.001 / 0.26417 / 256), 4).ToString();
                    txtGal.Text = (value / 256).ToString();
                    txtQuart.Text = (value / 64).ToString();
                    txtPint.Text = (value / 32).ToString();
                    txtCup.Text = (value / 16).ToString();
                    txtOunce.Text = (value / 2).ToString();
                    txtTbsp.Text = value.ToString();
                    txtTsp.Text = (value * 3).ToString();
                    break;
                case "teaspoon  (tsp)":
                    txtCuM.Text = Math.Round((value / 264.17 / 768), 7).ToString();
                    txtCuCm.Text = Math.Round((value / 264.17 * 1000000 / 768), 4).ToString();
                    txtLiter.Text = Math.Round((value / 0.26417 / 768), 4).ToString();
                    txtDekaliter.Text = Math.Round((value / 10 / 0.26417 / 768), 6).ToString();
                    txtMliter.Text = Math.Round((value / 0.001 / 0.26417 / 768), 4).ToString();
                    txtCc.Text = Math.Round((value / 0.001 / 0.26417 / 768), 4).ToString();
                    txtGal.Text = Math.Round((value / 768), 4).ToString();
                    txtQuart.Text = Math.Round((value / 192), 4).ToString();
                    txtPint.Text = Math.Round((value / 96), 4).ToString();
                    txtCup.Text = Math.Round((value / 48), 4).ToString();
                    txtOunce.Text = Math.Round((value / 6), 4).ToString();
                    txtTbsp.Text = Math.Round((value / 3), 4).ToString();
                    txtTsp.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtCuM.Clear();
            txtCuCm.Clear();
            txtLiter.Clear();
            txtDekaliter.Clear();
            txtMliter.Clear();
            txtCc.Clear();
            txtGal.Clear();
            txtQuart.Clear();
            txtPint.Clear();
            txtCup.Clear();
            txtOunce.Clear();
            txtTbsp.Clear();
            txtTsp.Clear();
        }
    }
}
