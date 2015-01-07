namespace MultipleFormApp
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
            this.addStudentBtton = new System.Windows.Forms.Button();
            this.viewStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentBtton
            // 
            this.addStudentBtton.Location = new System.Drawing.Point(126, 39);
            this.addStudentBtton.Name = "addStudentBtton";
            this.addStudentBtton.Size = new System.Drawing.Size(75, 23);
            this.addStudentBtton.TabIndex = 0;
            this.addStudentBtton.Text = "Add Student";
            this.addStudentBtton.UseVisualStyleBackColor = true;
            this.addStudentBtton.Click += new System.EventHandler(this.addStudentBtton_Click);
            // 
            // viewStudentButton
            // 
            this.viewStudentButton.Location = new System.Drawing.Point(105, 119);
            this.viewStudentButton.Name = "viewStudentButton";
            this.viewStudentButton.Size = new System.Drawing.Size(119, 23);
            this.viewStudentButton.TabIndex = 1;
            this.viewStudentButton.Text = "View Student ";
            this.viewStudentButton.UseVisualStyleBackColor = true;
            this.viewStudentButton.Click += new System.EventHandler(this.viewStudentButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.viewStudentButton);
            this.Controls.Add(this.addStudentBtton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentBtton;
        private System.Windows.Forms.Button viewStudentButton;
    }
}