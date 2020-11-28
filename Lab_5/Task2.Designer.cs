using System;
using System.Drawing;

namespace Lab_5
{
    partial class Task2
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
        Bitmap[] up = new Bitmap[3];
        Bitmap[] down = new Bitmap[3];
        Bitmap[] right = new Bitmap[3];
        Bitmap[] left = new Bitmap[3];
        Random rand;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(502, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 139);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(502, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 139);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(950, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 221);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(89, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 221);
            this.panel4.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Task2";
            this.Size = new System.Drawing.Size(1255, 795);
            this.Load += new System.EventHandler(this.Task2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
    }
}
