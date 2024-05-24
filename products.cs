using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static CsharpApi.products;

namespace CsharpApi
{
    public partial class products : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public products()
        {
            InitializeComponent();
        }
        private string imagePath;

        private async void getProd_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous data
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();

                HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/prod.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var products = JsonConvert.DeserializeObject<List<Product>>(responseBody);

                // Convert base64 string to Image and create a new property in Product for display
                foreach (var product in products)
                {
                    if (!string.IsNullOrEmpty(product.prod_img))
                    {
                        product.ImageBytes = Convert.FromBase64String(product.prod_img);
                    }
                }

                // Bind the list of products to the DataGridView
                dataGridView1.DataSource = products;

                // Set row height
                dataGridView1.RowTemplate.Height = 60;

                // Handle the CellFormatting event to stretch the image in the ImageBytes column
                dataGridView1.CellFormatting += (s, cellFormattingEventArgs) =>
                {
                    if (dataGridView1.Columns[cellFormattingEventArgs.ColumnIndex].Name == "ImageBytes" && cellFormattingEventArgs.RowIndex >= 0)
                    {
                        // Get the product from the current row
                        var product = dataGridView1.Rows[cellFormattingEventArgs.RowIndex].DataBoundItem as Product;

                        // Check if the product has an image
                        if (product != null && product.ImageBytes != null)
                        {
                            // Convert byte array to image
                            using (MemoryStream ms = new MemoryStream(product.ImageBytes))
                            {
                                Image img = Image.FromStream(ms);
                                // Stretch the image to fit within the cell
                                cellFormattingEventArgs.Value = new Bitmap(img, new Size(dataGridView1.Columns[cellFormattingEventArgs.ColumnIndex].Width, dataGridView1.RowTemplate.Height));
                            }
                        }
                    }
                };

                // Remove the "Product Image" column
                dataGridView1.Columns.Remove("prod_img");

                // Adjust column width mode
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public class Product
        {
            public int product_id { get; set; }

            public string product_name { get; set; }
            public string product_price { get; set; }
            public string product_stock { get; set; }
            public string prod_img { get; set; } // Base64 string
            public byte[] ImageBytes { get; set; } // New property to store image bytes
        }

        private async void addProd_Click(object sender, EventArgs e)
        {
            // Check if an image has been selected
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            // Convert the image to a byte array
            byte[] imageData = File.ReadAllBytes(imagePath);

            var productData = new
            {
                product_name = prodNameTxtbox.Text,
                product_price = prodPriceTxtbox.Text,
                product_stock = prodStocksTxtbox.Text,
                prod_img = Convert.ToBase64String(imageData)
            };
            string json = JsonConvert.SerializeObject(productData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/prod.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var newProduct = JsonConvert.DeserializeObject<Product>(responseBody);

                getProd_Click(null, null);
                // Do something with the new product, if needed

                // Clear the PictureBox
                pictureBox1.Image = null;
                prodNameTxtbox.Clear();
                prodPriceTxtbox.Clear();
                prodStocksTxtbox.Clear();
                MessageBox.Show("Product Added Successfully!");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error sending request: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void prodImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                imagePath = openFileDialog.FileName;

                // Display the selected image in the PictureBox control
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
