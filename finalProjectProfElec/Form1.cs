using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Bunifu.UI.WinForms;

namespace finalProjectProfElec
{
    public partial class CurrencyConverterForm : Form
    {
        private readonly string apiKey = "30b6412941fac0d4567a1f19";
        private readonly string baseApiUrl = "https://v6.exchangerate-api.com/v6/";
        public CurrencyConverterForm()
        {
            InitializeComponent();

            lblExchangeRate.Text = "";
            lblExchangeRateMessage.Text = "";

            LoadCurrencyData();
        }

        // Load currency codes and names from the API into dropdowns
        private async void LoadCurrencyData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"{baseApiUrl}{apiKey}/codes";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    JArray currencyCodes = (JArray)json["supported_codes"];

                    List<string> currencies = new List<string>();
                    foreach (var code in currencyCodes)
                    {
                        string currencyCode = code[0].ToString();
                        string currencyName = code[1].ToString();
                        currencies.Add($"{currencyCode} - {currencyName}"); // Add format: "USD - US Dollar"
                    }

                    // Actual population of dropdowns with currency codes + currency names
                    bunifuDropdownFrom.Items = currencies.ToArray();
                    bunifuDropdownTo.Items = currencies.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading currency data: " + ex.Message);
            }
        }

        // Fetch exchange rate and last update time from the API
        private async Task<(decimal exchangeRate, DateTime lastUpdate)> GetExchangeRate(string fromCurrency, string toCurrency)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{baseApiUrl}{apiKey}/latest/{fromCurrency}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JObject json = JObject.Parse(responseBody);
                decimal rate = json["conversion_rates"][toCurrency].Value<decimal>();
                long unixTime = json["time_last_update_unix"].Value<long>();
                DateTime lastUpdate = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;

                return (rate, lastUpdate);
            }
        }

        // Convert currencies based on user input
        private async void ConvertCurrency()
        {
            try
            {
                decimal amount;
                // User input validation
                if (!decimal.TryParse(bunifuTextBoxAmount.Text, out amount))
                {
                    MessageBox.Show("Please enter a valid numeric amount.");
                    return;
                }

                if (bunifuDropdownFrom.selectedIndex == -1 || bunifuDropdownTo.selectedIndex == -1)
                {
                    MessageBox.Show("Please select both currencies.");
                    return;
                }

                string fromCurrency = bunifuDropdownFrom.Items[bunifuDropdownFrom.selectedIndex].ToString().Split('-')[0].Trim();
                string toCurrency = bunifuDropdownTo.Items[bunifuDropdownTo.selectedIndex].ToString().Split('-')[0].Trim();

                // Get the exchange rate and last update time
                var (exchangeRate, lastUpdate) = await GetExchangeRate(fromCurrency, toCurrency);
                decimal convertedAmount = amount * exchangeRate;

                // Display the result
                bunifuLabelResult.Text = $"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}";

                // Update the exchange rate label
                lblExchangeRate.Text = $"1 {fromCurrency} = {exchangeRate:F4} {toCurrency}";
                lblExchangeRateMessage.Text = $"Current exchange rate from {fromCurrency} to {toCurrency}. \nLast updated: {lastUpdate:ddd, dd MMM yyyy HH:mm:ss} UTC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Button click event to convert currency
        private void bunifuButtonConvert_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        // Clear input fields and reset UI
        private void bunifuButtonClear_Click(object sender, EventArgs e)
        {
            bunifuTextBoxAmount.Clear();

            bunifuDropdownFrom.selectedIndex = -1;
            bunifuDropdownTo.selectedIndex = -1;

            bunifuLabelResult.Text = "Converted Amount";

            lblExchangeRate.Text = "";
            lblExchangeRateMessage.Text = "";
        }

        // Swap selected currencies in dropdowns
        private void bunifuButtonSwap_Click(object sender, EventArgs e)
        {
            // Swap the selected currencies in the dropdowns
            int tempIndex = bunifuDropdownFrom.selectedIndex;
            bunifuDropdownFrom.selectedIndex = bunifuDropdownTo.selectedIndex;
            bunifuDropdownTo.selectedIndex = tempIndex;

            // Trigger the conversion after swapping
            ConvertCurrency();
        }

    }
}
