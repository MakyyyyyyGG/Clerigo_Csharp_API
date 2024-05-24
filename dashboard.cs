using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpApi
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            var account = new Form1();
            this.Hide();
            account.Show();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            var products = new products();
            this.Hide();
            products.Show();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            var transaction = new transactions();
            this.Hide();
            transaction.Show();
        }
    }
}
