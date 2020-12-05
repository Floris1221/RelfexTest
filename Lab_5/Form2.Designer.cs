namespace Lab_5
{
    partial class Form2
    {
        /// <summary>
        Form1 gl;
        static public int zadanie = 1;
        Form2 fr;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.task31 = new Lab_5.Task3();
            this.task21 = new Lab_5.Task2();
            this.task11 = new Lab_5.Test.Task1();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.task31);
            this.panel1.Controls.Add(this.task21);
            this.panel1.Controls.Add(this.task11);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 801);
            this.panel1.TabIndex = 0;
            // 
            // task31
            // 
            this.task31.Enabled = false;
            this.task31.Location = new System.Drawing.Point(-10, 0);
            this.task31.Name = "task31";
            this.task31.Size = new System.Drawing.Size(1255, 795);
            this.task31.TabIndex = 3;
            this.task31.Visible = false;
            // 
            // task21
            // 
            this.task21.BackColor = System.Drawing.SystemColors.Control;
            this.task21.Enabled = false;
            this.task21.Location = new System.Drawing.Point(0, 0);
            this.task21.Name = "task21";
            this.task21.Size = new System.Drawing.Size(1242, 798);
            this.task21.TabIndex = 2;
            this.task21.Visible = false;
            // 
            // task11
            // 
            this.task11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.task11.Enabled = false;
            this.task11.Location = new System.Drawing.Point(0, 0);
            this.task11.Name = "task11";
            this.task11.Size = new System.Drawing.Size(1242, 798);
            this.task11.TabIndex = 1;
            this.task11.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 169);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 792);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Test.Task1 task11;
        private Task2 task21;
        private Task3 task31;
    }
}