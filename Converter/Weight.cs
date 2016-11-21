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
    public partial class Weight : UserControl
    {
        public Weight()
        {
            InitializeComponent();
            int index = cmbWeightUnit.FindString("pound  (lb)");
            cmbWeightUnit.SelectedIndex = index;
            Calculation();
        }

        private void cmbWeightUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtWeight.Text);
            if (isValid)
            {
                double weight = double.Parse(txtWeight.Text);
                WeightConverter(weight, cmbWeightUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void WeightConverter(double value, string units)
        {
            switch (units)
            {
                case "gram (g)":
                    txtGram.Text = value.ToString();
                    txtMgram.Text = (value * 1000).ToString();
                    txtKgram.Text = (value / 1000).ToString();
                    txtTon.Text = (value / 1000000).ToString();
                    txtPound.Text = Math.Round((value / 453.59237), 4).ToString();
                    txtOz.Text = Math.Round((value / 28.3495231), 4).ToString();
                    break;
                case "milligram  (mg)":
                    txtGram.Text = (value / 1000).ToString();
                    txtMgram.Text = value.ToString();
                    txtKgram.Text = (value / 1000000).ToString();
                    txtTon.Text = (value / 1000000000).ToString();
                    txtPound.Text = Math.Round((value / 453.59237 / 1000), 7).ToString();
                    txtOz.Text = Math.Round((value / 28.3495231 / 1000), 7).ToString();
                    break;
                case "kilogram  (kg)":
                    txtGram.Text = (value * 1000).ToString();
                    txtMgram.Text = (value * 1000000).ToString();
                    txtKgram.Text = value.ToString();
                    txtTon.Text = (value / 1000).ToString();
                    txtPound.Text = Math.Round((value / 453.59237 * 1000), 4).ToString();
                    txtOz.Text = Math.Round((value / 28.3495231 * 1000), 4).ToString();
                    break;
                case "ton  (t)":
                    txtGram.Text = (value * 1000000).ToString();
                    txtMgram.Text = (value * 1000000000).ToString();
                    txtKgram.Text = (value * 1000).ToString();
                    txtTon.Text = value.ToString();
                    txtPound.Text = Math.Round((value / 453.59237 * 1000000), 4).ToString();
                    txtOz.Text = Math.Round((value / 28.3495231 * 1000000), 4).ToString();
                    break;
                case "pound  (lb)":
                    txtGram.Text = Math.Round((value * 453.59237), 4).ToString();
                    txtMgram.Text = Math.Round((value * 453.59237 * 1000), 4).ToString();
                    txtKgram.Text = Math.Round((value * 453.59237 / 1000), 4).ToString();
                    txtTon.Text = Math.Round((value * 453.59237 / 1000000), 4).ToString();
                    txtPound.Text = value.ToString();
                    txtOz.Text = (value * 16).ToString();
                    break;
                case "ounce  (oz)":
                    txtGram.Text = Math.Round((value * 28.3495231), 4).ToString();
                    txtMgram.Text = Math.Round((value * 28.3495231 * 1000), 4).ToString();
                    txtKgram.Text = Math.Round((value * 28.3495231 / 1000), 4).ToString();
                    txtTon.Text = Math.Round((value * 28.3495231 / 1000000), 7).ToString();
                    txtPound.Text = (value / 16).ToString();
                    txtOz.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtGram.Clear();
            txtMgram.Clear();
            txtKgram.Clear();
            txtTon.Clear();
            txtPound.Clear();
            txtOz.Clear();
        }
    }
}
