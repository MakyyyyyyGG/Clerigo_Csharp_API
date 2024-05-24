using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CsharpApi.Form1;
using static CsharpApi.transactions;

namespace CsharpApi
{
    public partial class transactions : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public transactions()
        {
            InitializeComponent();
   
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            this.Hide();
            dashboard.Show();
        }

        private async void getTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous data
                dataGridView1.DataSource = null;

                HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/transaction.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var transactions = JsonConvert.DeserializeObject<List<Transaction>>(responseBody);

                // Bind the list of users to the DataGridView
                dataGridView1.DataSource = transactions;

                // Ensure columns fill the container
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public class Transaction
        {
            public string category { get; set; }
            public float cost { get; set; }
            public string transaction_date { get; set; }
        }

        private async void addTransaction_Click(object sender, EventArgs e)
        {
            var transactionData = new { category = categoryCombo.SelectedItem.ToString(), cost = costTxtbox.Text };
            string json = JsonConvert.SerializeObject(transactionData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/transaction.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var transaction = JsonConvert.DeserializeObject<Transaction>(responseBody);

                getTransaction_Click(null, null);
                // Do something with the transaction object
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Reset the TextBox and ComboBox after adding the transaction
            categoryCombo.SelectedIndex = -1; // Reset ComboBox selection

            costTxtbox.Clear(); // Clear TextBox
        }
    }
}
