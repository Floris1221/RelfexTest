namespace Lab_5
{
    partial class Form2
    {
        /// <summary>
        Form1 start;
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
            this.task11 = new Lab_5.Test.Task1();
            this.SuspendLayout();
            // 
            // task11
            // 
            this.task11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.task11.Location = new System.Drawing.Point(-3, 0);
            this.task11.Name = "task11";
            this.task11.Size = new System.Drawing.Size(1255, 814);
            this.task11.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1237, 767);
            this.Controls.Add(this.task11);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Test.Task1 task11;
    }
}