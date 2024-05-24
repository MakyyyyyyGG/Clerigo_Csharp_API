namespace CsharpApi
{
    partial class dashboard
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
            this.accountBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountBtn
            // 
            this.accountBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.accountBtn.Location = new System.Drawing.Point(265, 114);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(222, 68);
            this.accountBtn.TabIndex = 0;
            this.accountBtn.Text = "Accounts";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.productBtn.Location = new System.Drawing.Point(265, 188);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(222, 68);
            this.productBtn.TabIndex = 1;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.transactionBtn.Location = new System.Drawing.Point(265, 262);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(222, 68);
            this.transactionBtn.TabIndex = 2;
            this.transactionBtn.Text = "Transactions";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.accountBtn);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button transactionBtn;
    }
}