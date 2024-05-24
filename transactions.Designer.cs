namespace CsharpApi
{
    partial class transactions
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
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getTransaction = new System.Windows.Forms.Button();
            this.addTransaction = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Salary",
            "Utility",
            "Maintenance",
            "Miscellaneous"});
            this.categoryCombo.Location = new System.Drawing.Point(188, 280);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(164, 24);
            this.categoryCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Category";
            // 
            // costTxtbox
            // 
            this.costTxtbox.Location = new System.Drawing.Point(490, 285);
            this.costTxtbox.Name = "costTxtbox";
            this.costTxtbox.Size = new System.Drawing.Size(237, 22);
            this.costTxtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // getTransaction
            // 
            this.getTransaction.Location = new System.Drawing.Point(64, 222);
            this.getTransaction.Name = "getTransaction";
            this.getTransaction.Size = new System.Drawing.Size(663, 43);
            this.getTransaction.TabIndex = 5;
            this.getTransaction.Text = "Get Transactions";
            this.getTransaction.UseVisualStyleBackColor = true;
            this.getTransaction.Click += new System.EventHandler(this.getTransaction_Click);
            // 
            // addTransaction
            // 
            this.addTransaction.Location = new System.Drawing.Point(186, 352);
            this.addTransaction.Name = "addTransaction";
            this.addTransaction.Size = new System.Drawing.Size(542, 61);
            this.addTransaction.TabIndex = 6;
            this.addTransaction.Text = "Add Transaction";
            this.addTransaction.UseVisualStyleBackColor = true;
            this.addTransaction.Click += new System.EventHandler(this.addTransaction_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(65, 352);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(115, 61);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addTransaction);
            this.Controls.Add(this.getTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getTransaction;
        private System.Windows.Forms.Button addTransaction;
        private System.Windows.Forms.Button backBtn;
    }
}