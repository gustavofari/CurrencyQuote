using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarQuote {
    public partial class FrmDollarQuote : Form {
        public FrmDollarQuote() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e) {

            const string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=25b84a2e";
            
            using (HttpClient client = new HttpClient()) {

                try {
                    HttpResponseMessage response = client.GetAsync(strURL).Result;

                    if (response.IsSuccessStatusCode) {

                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        // C -> CURRENCIES (MOEDA)
                        // P -> PORCENT (PORCENTAGEM)
                        LabelBuyDollar.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        LabelSellDollar.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        LabelVariation.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation);

                    } else {

                        LabelBuyDollar.Text = "-";
                        LabelSellDollar.Text = "-";
                        LabelVariation.Text = "-";
                    }

                } catch (Exception error) {

                    MessageBox.Show(error.Message);
                }
                
            }
        }
    }
}
