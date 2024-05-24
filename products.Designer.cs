namespace CsharpApi
{
    partial class products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getProd = new System.Windows.Forms.Button();
            this.prodNameTxtbox = new System.Windows.Forms.TextBox();
            this.prodPriceTxtbox = new System.Windows.Forms.TextBox();
            this.prodStocksTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addProd = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.prodImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(654, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // getProd
            // 
            this.getProd.Location = new System.Drawing.Point(68, 191);
            this.getProd.Name = "getProd";
            this.getProd.Size = new System.Drawing.Size(654, 50);
            this.getProd.TabIndex = 1;
            this.getProd.Text = "Get Products";
            this.getProd.UseVisualStyleBackColor = true;
            this.getProd.Click += new System.EventHandler(this.getProd_Click);
            // 
            // prodNameTxtbox
            // 
            this.prodNameTxtbox.Location = new System.Drawing.Point(141, 257);
            this.prodNameTxtbox.Name = "prodNameTxtbox";
            this.prodNameTxtbox.Size = new System.Drawing.Size(100, 22);
            this.prodNameTxtbox.TabIndex = 2;
            // 
            // prodPriceTxtbox
            // 
            this.prodPriceTxtbox.Location = new System.Drawing.Point(483, 256);
            this.prodPriceTxtbox.Name = "prodPriceTxtbox";
            this.prodPriceTxtbox.Size = new System.Drawing.Size(100, 22);
            this.prodPriceTxtbox.TabIndex = 3;
            // 
            // prodStocksTxtbox
            // 
            this.prodStocksTxtbox.Location = new System.Drawing.Point(141, 347);
            this.prodStocksTxtbox.Name = "prodStocksTxtbox";
            this.prodStocksTxtbox.Size = new System.Drawing.Size(100, 22);
            this.prodStocksTxtbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stocks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // addProd
            // 
            this.addProd.Location = new System.Drawing.Point(586, 377);
            this.addProd.Name = "addProd";
            this.addProd.Size = new System.Drawing.Size(177, 61);
            this.addProd.TabIndex = 8;
            this.addProd.Text = "Add Product";
            this.addProd.UseVisualStyleBackColor = true;
            this.addProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // prodImage
            // 
            this.prodImage.Location = new System.Drawing.Point(483, 347);
            this.prodImage.Name = "prodImage";
            this.prodImage.Size = new System.Drawing.Size(114, 23);
            this.prodImage.TabIndex = 9;
            this.prodImage.Text = "Choose Image";
            this.prodImage.UseVisualStyleBackColor = true;
            this.prodImage.Click += new System.EventHandler(this.prodImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(632, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(483, 377);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 61);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodImage);
            this.Controls.Add(this.addProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodStocksTxtbox);
            this.Controls.Add(this.prodPriceTxtbox);
            this.Controls.Add(this.prodNameTxtbox);
            this.Controls.Add(this.getProd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getProd;
        private System.Windows.Forms.TextBox prodNameTxtbox;
        private System.Windows.Forms.TextBox prodPriceTxtbox;
        private System.Windows.Forms.TextBox prodStocksTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addProd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button prodImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
    }
}