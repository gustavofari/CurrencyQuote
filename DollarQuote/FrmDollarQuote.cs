using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;

namespace DollarQuote {
    public partial class FrmDollarQuote : Form {

        int time = 0;

        public FrmDollarQuote() {

            InitializeComponent();
            loadingScreen.Visible = false;
            
        }

        private void btnSearch_Click(object sender, EventArgs e) {

            time = 0;
            loadingScreen.Visible = true;
            timer1.Enabled = true;

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

        private void FrmDollarQuote_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {

            time += 3;

            if(time >= 30) {

                loadingScreen.Visible = false;
            }
        }
    }
}
