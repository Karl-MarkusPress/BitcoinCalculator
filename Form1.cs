using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public BitcoinRates GetRates(string currency)
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(response);
            }

            return bitcoin;
        }
        private void ratesBtn_Click(object sender, EventArgs e)
        {
            if (currencyBox.SelectedItem is null) return;

            if (currencyBox.SelectedItem.ToString() == "EUR")
            {
                try
                {
                    BitcoinRates bitcoin = GetRates("EUR");
                    float result = Int32.Parse(amountBox.Text) * bitcoin.bpi.EUR.rate_float;
                    resultBox.Text = $"{result.ToString()} {bitcoin.bpi.EUR.code}";
                } catch { }
            }
            else if (currencyBox.SelectedItem.ToString() == "USD")
            {
                try
                {
                    BitcoinRates bitcoin = GetRates("USD");
                    float result = Int32.Parse(amountBox.Text) * bitcoin.bpi.USD.rate_float;
                    resultBox.Text = $"{result.ToString()} {bitcoin.bpi.USD.code}";
                } catch { }
            }
        }
    }
}
