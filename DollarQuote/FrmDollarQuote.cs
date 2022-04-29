using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;

namespace DollarQuote {
    public partial class FrmDollarQuote : Form {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public FrmDollarQuote() {

            InitializeComponent();
            
        }

        private void btnSearching(object sender, EventArgs e) {

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

        private Color SelectThemeColor() {

            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index) {

                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender) {

            if (btnSender != null) {

                if(currentButton != (Button)btnSender) {

                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton() {

            foreach (Control previousBtn in panelMenu.Controls) {

                if (previousBtn.GetType() == typeof(Button)) {

                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void btnQuote_Click(object sender, EventArgs e) {

        }

        private void btnConversor_Click(object sender, EventArgs e) {

        }
    }
}
