namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.ratesBtn = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Items.AddRange(new object[] {
            "Select currency",
            "EUR",
            "USD"});
            this.currencyBox.Location = new System.Drawing.Point(86, 130);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(226, 21);
            this.currencyBox.TabIndex = 0;
            // 
            // ratesBtn
            // 
            this.ratesBtn.Location = new System.Drawing.Point(376, 130);
            this.ratesBtn.Name = "ratesBtn";
            this.ratesBtn.Size = new System.Drawing.Size(75, 23);
            this.ratesBtn.TabIndex = 1;
            this.ratesBtn.Text = "Get rates";
            this.ratesBtn.UseVisualStyleBackColor = true;
            this.ratesBtn.Click += new System.EventHandler(this.ratesBtn_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(86, 206);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(226, 20);
            this.amountBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of bitcoin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(89, 266);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(223, 20);
            this.resultBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(595, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.ratesBtn);
            this.Controls.Add(this.currencyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.Button ratesBtn;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label2;
    }
}

