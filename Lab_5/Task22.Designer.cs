using System;
using System.Diagnostics;
using System.Drawing;

namespace Lab_5
{
    partial class Task22
    {
        /// <summary>
        Image black_arrow;
        Image green_arrow;
        Image red_arrow;
        Bitmap bmp_g_d;
        Bitmap bmp_b_d;
        Bitmap bmp_r_d;
        Bitmap bmp_g_u;
        Bitmap bmp_b_u;
        Bitmap bmp_r_u;
        Bitmap bmp_g_r;
        Bitmap bmp_b_r;
        Bitmap bmp_r_r;
        Bitmap bmp_g_l;
        Bitmap bmp_b_l;
        Bitmap bmp_r_l;
        Random rand;
        static int podejscie = 0;
        Stopwatch watch = new Stopwatch();
        Form2 fr;
        int proba = 0;
        int blad = 0;
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(73, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 221);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(934, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 221);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(486, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 139);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(486, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 139);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(175, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 88);
            this.label1.TabIndex = 7;
            this.label1.Text = "To były trzy próby instruktarzowe. \r\nWciśnij START aby rozpocząć próbe właściwą.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(379, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 147);
            this.button1.TabIndex = 6;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task22";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task22";
            this.Load += new System.EventHandler(this.Task22_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Task22_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}