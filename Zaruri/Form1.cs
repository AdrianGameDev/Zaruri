using RestSharp;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace DiceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnRollDice_Click(object sender, EventArgs e)
        {
            try
            {
                int numDice = int.Parse(txtNumDice.Text);
                int numSides = int.Parse(txtNumSides.Text);

                var client = new RestClient("https://api.random.org");
                var request = new RestRequest("/json-rpc/2/invoke", Method.Post);
                string apiKey = "d24a0773-7a2c-490d-8379-1372f4ded0b0";

                var requestData = new
                {
                    jsonrpc = "2.0",
                    method = "generateIntegers",
                    @params = new
                    {
                        apiKey = apiKey,
                        n = numDice,
                        min = 1,
                        max = numSides,
                        replacement = true
                    },
                    id = 1
                };

                request.AddJsonBody(requestData);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    JsonDocument document = JsonDocument.Parse(response.Content);
                    JsonElement root = document.RootElement;

                    if (root.TryGetProperty("result", out JsonElement result))
                    {
                        if (result.TryGetProperty("random", out JsonElement randomData))
                        {
                            if (randomData.TryGetProperty("data", out JsonElement data))
                            {
                                var resultArray = data.EnumerateArray();

                                // Display the dice results
                                lstResults.Items.Clear();
                                foreach (var value in resultArray)
                                {
                                    lstResults.Items.Add(value.GetInt32());
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
