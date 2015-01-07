namespace StockManagementSystemUI
{
    partial class StockInUI
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
            this.addItemIdTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addItemIdTextBox
            // 
            this.addItemIdTextBox.Location = new System.Drawing.Point(116, 46);
            this.addItemIdTextBox.Name = "addItemIdTextBox";
            this.addItemIdTextBox.Size = new System.Drawing.Size(110, 20);
            this.addItemIdTextBox.TabIndex = 0;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(99, 141);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "In";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Id:";
            // 
            // addQuantityTextBox
            // 
            this.addQuantityTextBox.Location = new System.Drawing.Point(116, 91);
            this.addQuantityTextBox.Name = "addQuantityTextBox";
            this.addQuantityTextBox.Size = new System.Drawing.Size(110, 20);
            this.addQuantityTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.addQuantityTextBox);
            this.Controls.Add(this.addItemIdTextBox);
            this.Name = "StockInUI";
            this.Text = "StockInUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addItemIdTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addQuantityTextBox;
        private System.Windows.Forms.Label label2;
    }
}