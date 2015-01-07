namespace StockManagementSystemUI
{
    partial class StockOutUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outItemButton = new System.Windows.Forms.Button();
            this.outQuantityTextBox = new System.Windows.Forms.TextBox();
            this.outItemIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Id:";
            // 
            // outItemButton
            // 
            this.outItemButton.Location = new System.Drawing.Point(99, 166);
            this.outItemButton.Name = "outItemButton";
            this.outItemButton.Size = new System.Drawing.Size(75, 23);
            this.outItemButton.TabIndex = 5;
            this.outItemButton.Text = "Out";
            this.outItemButton.UseVisualStyleBackColor = true;
            this.outItemButton.Click += new System.EventHandler(this.outItemButton_Click);
            // 
            // outQuantityTextBox
            // 
            this.outQuantityTextBox.Location = new System.Drawing.Point(116, 116);
            this.outQuantityTextBox.Name = "outQuantityTextBox";
            this.outQuantityTextBox.Size = new System.Drawing.Size(110, 20);
            this.outQuantityTextBox.TabIndex = 3;
            // 
            // outItemIdTextBox
            // 
            this.outItemIdTextBox.Location = new System.Drawing.Point(116, 71);
            this.outItemIdTextBox.Name = "outItemIdTextBox";
            this.outItemIdTextBox.Size = new System.Drawing.Size(110, 20);
            this.outItemIdTextBox.TabIndex = 4;
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outItemButton);
            this.Controls.Add(this.outQuantityTextBox);
            this.Controls.Add(this.outItemIdTextBox);
            this.Name = "StockOutUI";
            this.Text = "StockOutUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button outItemButton;
        private System.Windows.Forms.TextBox outQuantityTextBox;
        private System.Windows.Forms.TextBox outItemIdTextBox;
    }
}