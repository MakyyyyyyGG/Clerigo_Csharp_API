using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static CsharpApi.Form1;

namespace CsharpApi
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous data
                dataGridView1.DataSource = null;

                HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/api.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                // Bind the list of users to the DataGridView
                dataGridView1.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var userData = new { username = txtUsername.Text, pass = txtPassword.Text, email = txtEmail.Text };
            string json = JsonConvert.SerializeObject(userData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/api.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var user = JsonConvert.DeserializeObject<User>(responseBody);

                btnGet_Click(null, null);
                // Do something with the user object
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public class User
        {
            public string username { get; set; }
            public string pass { get; set; }
            public string email { get; set; }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
