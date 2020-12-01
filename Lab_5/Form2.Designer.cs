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
            this.task22 = new Lab_5.Task2();
            this.task11 = new Lab_5.Test.Task1();
            this.task31 = new Lab_5.Task3();
            this.SuspendLayout();
            // 
            // task22
            // 
            this.task22.BackColor = System.Drawing.SystemColors.Control;
            this.task22.Location = new System.Drawing.Point(-1, -11);
            this.task22.Name = "task22";
            this.task22.Size = new System.Drawing.Size(1569, 994);
            this.task22.TabIndex = 2;
            this.task22.Visible = false;
            // 
            // task11
            // 
            this.task11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.task11.Location = new System.Drawing.Point(-14, 0);
            this.task11.Name = "task11";
            this.task11.Size = new System.Drawing.Size(1256, 766);
            this.task11.TabIndex = 0;
            this.task11.Visible = false;
            // 
            // task31
            // 
            this.task31.Location = new System.Drawing.Point(-1, 0);
            this.task31.Name = "task31";
            this.task31.Size = new System.Drawing.Size(1569, 970);
            this.task31.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1560, 969);
            this.Controls.Add(this.task31);
            this.Controls.Add(this.task22);
            this.Controls.Add(this.task11);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Test.Task1 task11;
        private Task2 task22;
        private Task3 task31;
    }
}