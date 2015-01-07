namespace MultipleFormApp
{
    partial class ViewStudentUI
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
            this.view_Button = new System.Windows.Forms.Button();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // view_Button
            // 
            this.view_Button.Location = new System.Drawing.Point(92, 45);
            this.view_Button.Name = "view_Button";
            this.view_Button.Size = new System.Drawing.Size(75, 23);
            this.view_Button.TabIndex = 0;
            this.view_Button.Text = "View";
            this.view_Button.UseVisualStyleBackColor = true;
            this.view_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(33, 101);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(193, 108);
            this.studentListBox.TabIndex = 1;
            // 
            // ViewStudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.view_Button);
            this.Name = "ViewStudentUI";
            this.Text = "ViewStudentUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_Button;
        private System.Windows.Forms.ListBox studentListBox;
    }
}