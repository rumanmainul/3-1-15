namespace StockManagementSystemUI
{
    partial class MainUI
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
            this.stockInButton = new System.Windows.Forms.Button();
            this.stockOutButton = new System.Windows.Forms.Button();
            this.viewCurrentStockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockInButton
            // 
            this.stockInButton.Location = new System.Drawing.Point(74, 39);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(116, 55);
            this.stockInButton.TabIndex = 0;
            this.stockInButton.Text = "Stock In";
            this.stockInButton.UseVisualStyleBackColor = true;
            this.stockInButton.Click += new System.EventHandler(this.stockInButton_Click);
            // 
            // stockOutButton
            // 
            this.stockOutButton.Location = new System.Drawing.Point(74, 104);
            this.stockOutButton.Name = "stockOutButton";
            this.stockOutButton.Size = new System.Drawing.Size(116, 51);
            this.stockOutButton.TabIndex = 0;
            this.stockOutButton.Text = "Stock Out";
            this.stockOutButton.UseVisualStyleBackColor = true;
            this.stockOutButton.Click += new System.EventHandler(this.stockOutButton_Click);
            // 
            // viewCurrentStockButton
            // 
            this.viewCurrentStockButton.Location = new System.Drawing.Point(74, 168);
            this.viewCurrentStockButton.Name = "viewCurrentStockButton";
            this.viewCurrentStockButton.Size = new System.Drawing.Size(116, 53);
            this.viewCurrentStockButton.TabIndex = 0;
            this.viewCurrentStockButton.Text = "View Current Stock";
            this.viewCurrentStockButton.UseVisualStyleBackColor = true;
            this.viewCurrentStockButton.Click += new System.EventHandler(this.viewCurrentStockButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.viewCurrentStockButton);
            this.Controls.Add(this.stockOutButton);
            this.Controls.Add(this.stockInButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stockInButton;
        private System.Windows.Forms.Button stockOutButton;
        private System.Windows.Forms.Button viewCurrentStockButton;
    }
}

