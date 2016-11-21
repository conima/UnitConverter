using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Converter.Common;

namespace Converter
{
    public partial class Currency : UserControl
    {
        CurrencyRates newRates = new CurrencyRates();
        public Currency()
        {
            InitializeComponent();
            try
            {
                var url = "https://openexchangerates.org/api/latest.json?app_id=266fc036d6994d3f8cfe050ac81ba4b0";
                var currencyRates = _download_serialized_json_data<CurrencyRates>(url);
                Rates rate = new Rates();
                rate.BYR = currencyRates.rates.BYR;
                rate.CAD = currencyRates.rates.CAD;
                rate.EUR = currencyRates.rates.EUR;
                rate.GBP = currencyRates.rates.GBP;
                rate.ILS = currencyRates.rates.ILS;
                rate.JPY = currencyRates.rates.JPY;
                rate.RUB = currencyRates.rates.RUB;
                rate.UAH = currencyRates.rates.UAH;
                rate.USD = currencyRates.rates.USD;
                newRates.rates = rate;
                int index = cmbCurrencyUnit.FindString("Canadian dollar  (CAD)");
                cmbCurrencyUnit.SelectedIndex = index;
                Calculation();
            }
            catch (Exception)
            {

                lblError.Text = "Sorry, unable to update rates. Please check your network connection.";
            }
            
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void cmbCurrencyUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Validation valid = new Validation();
            bool isValid = valid.IsValidValue(txtCurrency.Text);
            if (isValid)
            {
                double currency = double.Parse(txtCurrency.Text);
                CurrencyConverter(currency, cmbCurrencyUnit.SelectedItem.ToString().Trim());
            }
            else
            {
                InvalidValue();
            }
        }

        private void CurrencyConverter(double value, string units)
        {
            switch (units)
            {
                case "US dollar (USD)":
                    txtUSD.Text = (value * newRates.rates.USD).ToString();
                    txtCAD.Text = (value * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value * newRates.rates.JPY).ToString();
                    txtILS.Text = (value * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value * newRates.rates.UAH).ToString();
                    break;
                case "Canadian dollar  (CAD)":
                    txtUSD.Text = (value / newRates.rates.CAD).ToString();
                    txtCAD.Text = value.ToString();
                    txtEUR.Text = (value / newRates.rates.CAD * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value / newRates.rates.CAD * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value / newRates.rates.CAD * newRates.rates.JPY).ToString();
                    txtILS.Text = (value / newRates.rates.CAD * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value / newRates.rates.CAD * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value / newRates.rates.CAD * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value / newRates.rates.CAD * newRates.rates.UAH).ToString();
                    break;
                case "Euro  (EUR)":
                    txtUSD.Text = (value / newRates.rates.EUR).ToString();
                    txtCAD.Text = (value / newRates.rates.EUR * newRates.rates.CAD).ToString();
                    txtEUR.Text = value.ToString();
                    txtGBP.Text = (value / newRates.rates.EUR * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value / newRates.rates.EUR * newRates.rates.JPY).ToString();
                    txtILS.Text = (value / newRates.rates.EUR * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value / newRates.rates.EUR * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value / newRates.rates.EUR * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value / newRates.rates.EUR * newRates.rates.UAH).ToString();
                    break;
                case "British Pound  (GBP)":
                    txtUSD.Text = (value / newRates.rates.GBP).ToString();
                    txtCAD.Text = (value / newRates.rates.GBP * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value / newRates.rates.GBP * newRates.rates.EUR).ToString();
                    txtGBP.Text = value.ToString();
                    txtJPY.Text = (value / newRates.rates.GBP * newRates.rates.JPY).ToString();
                    txtILS.Text = (value / newRates.rates.GBP * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value / newRates.rates.GBP * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value / newRates.rates.GBP * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value / newRates.rates.GBP * newRates.rates.UAH).ToString();
                    break;
                case "Japanese Yen  (JPY)":
                    txtUSD.Text = (value / newRates.rates.JPY).ToString();
                    txtCAD.Text = (value / newRates.rates.JPY * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value / newRates.rates.JPY * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value / newRates.rates.JPY * newRates.rates.GBP).ToString();
                    txtJPY.Text = value.ToString();
                    txtILS.Text = (value / newRates.rates.JPY * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value / newRates.rates.JPY * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value / newRates.rates.JPY * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value / newRates.rates.JPY * newRates.rates.UAH).ToString();
                    break;
                case "Israeli New Shekel  (ILS)":
                    txtUSD.Text = (value / newRates.rates.ILS).ToString();
                    txtCAD.Text = (value / newRates.rates.ILS * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value / newRates.rates.ILS * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value / newRates.rates.ILS * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value / newRates.rates.ILS * newRates.rates.JPY).ToString();
                    txtILS.Text = value.ToString();
                    txtRUB.Text = (value / newRates.rates.ILS * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value / newRates.rates.ILS * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value / newRates.rates.ILS * newRates.rates.UAH).ToString();
                    break;
                case "Russian Ruble  (RUB)":
                    txtUSD.Text = (value / newRates.rates.RUB).ToString();
                    txtCAD.Text = (value / newRates.rates.RUB * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value / newRates.rates.RUB * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value / newRates.rates.RUB * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value / newRates.rates.RUB * newRates.rates.JPY).ToString();
                    txtILS.Text = (value / newRates.rates.RUB * newRates.rates.ILS).ToString();
                    txtRUB.Text = value.ToString();
                    txtBYR.Text = (value / newRates.rates.RUB * newRates.rates.BYR).ToString();
                    txtUAH.Text = (value / newRates.rates.RUB * newRates.rates.UAH).ToString();
                    break;
                case "Belarussian Ruble (BYR)":
                    txtUSD.Text = (value / newRates.rates.BYR).ToString();
                    txtCAD.Text = (value / newRates.rates.BYR * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value / newRates.rates.BYR * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value / newRates.rates.BYR * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value / newRates.rates.BYR * newRates.rates.JPY).ToString();
                    txtILS.Text = (value / newRates.rates.BYR * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value / newRates.rates.BYR * newRates.rates.RUB).ToString();
                    txtBYR.Text = value.ToString();
                    txtUAH.Text = (value / newRates.rates.BYR * newRates.rates.UAH).ToString();
                    break;
                case "Ukrainian Hryvnia  (UAH)":
                    txtUSD.Text = (value / newRates.rates.UAH).ToString();
                    txtCAD.Text = (value / newRates.rates.UAH * newRates.rates.CAD).ToString();
                    txtEUR.Text = (value / newRates.rates.UAH * newRates.rates.EUR).ToString();
                    txtGBP.Text = (value / newRates.rates.UAH * newRates.rates.GBP).ToString();
                    txtJPY.Text = (value / newRates.rates.UAH * newRates.rates.JPY).ToString();
                    txtILS.Text = (value / newRates.rates.UAH * newRates.rates.ILS).ToString();
                    txtRUB.Text = (value / newRates.rates.UAH * newRates.rates.RUB).ToString();
                    txtBYR.Text = (value / newRates.rates.UAH * newRates.rates.BYR).ToString();
                    txtUAH.Text = value.ToString();
                    break;
            }
        }

        private void InvalidValue()
        {
            txtUSD.Clear();
            txtCAD.Clear();
            txtEUR.Clear();
            txtGBP.Clear();
            txtJPY.Clear();
            txtILS.Clear();
            txtRUB.Clear();
            txtBYR.Clear();
            txtUAH.Clear();
        }
    }
}
