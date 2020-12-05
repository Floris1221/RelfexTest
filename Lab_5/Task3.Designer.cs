using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_5
{
    partial class Task3
    {
        /// <summary> 
        Random rand = new Random();
        Stopwatch watch = new Stopwatch();
        public int zielony;
        public int figura;
        PictureBox[] picbox;
        int proba;

        //Drawing
        Drawing dr1;
        Drawing dr2;
        Drawing dr3;
        Drawing dr4;
        Drawing dr5;
        Drawing dr6;
        Drawing dr7;
        Drawing dr8;
        Drawing dr9;
        Drawing dr10;
        Drawing dr11;
        Drawing dr12;
        Drawing dr13;
        Drawing dr14;
        Drawing dr15;
        Drawing dr16;
        Drawing dr17;
        Drawing dr18;
        Drawing dr19;
        Drawing dr20;
        Drawing dr21;
        Drawing dr22;
        Drawing dr23;
        Drawing dr24;
        Drawing dr25;
        Drawing dr26;
        Drawing dr27;
        Drawing dr28;
        Drawing dr29;
        Drawing dr30;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 113);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 113);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 492);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 113);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 628);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(153, 113);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(227, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(153, 113);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(227, 188);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(153, 113);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(227, 338);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(153, 113);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(227, 492);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(153, 113);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(227, 628);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(153, 113);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(448, 37);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(153, 113);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(448, 188);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(153, 113);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(448, 338);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(153, 113);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(448, 492);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(153, 113);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(448, 628);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(153, 113);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(662, 37);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(153, 113);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(662, 188);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(153, 113);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(662, 338);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(153, 113);
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(662, 492);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(153, 113);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(662, 628);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(153, 113);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(875, 37);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(153, 113);
            this.pictureBox21.TabIndex = 0;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(875, 188);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(153, 113);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(875, 338);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(153, 113);
            this.pictureBox23.TabIndex = 0;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(875, 492);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(153, 113);
            this.pictureBox24.TabIndex = 0;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(875, 628);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(153, 113);
            this.pictureBox25.TabIndex = 0;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(1066, 37);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(153, 113);
            this.pictureBox26.TabIndex = 0;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(1066, 188);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(153, 113);
            this.pictureBox27.TabIndex = 0;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(1066, 338);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(153, 113);
            this.pictureBox28.TabIndex = 0;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox29
            // 
            this.pictureBox29.Location = new System.Drawing.Point(1066, 492);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(153, 113);
            this.pictureBox29.TabIndex = 0;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(1066, 628);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(153, 113);
            this.pictureBox30.TabIndex = 0;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Task3";
            this.Size = new System.Drawing.Size(1255, 795);
            this.Load += new System.EventHandler(this.Task3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.PictureBox pictureBox16;
        public System.Windows.Forms.PictureBox pictureBox17;
        public System.Windows.Forms.PictureBox pictureBox18;
        public System.Windows.Forms.PictureBox pictureBox19;
        public System.Windows.Forms.PictureBox pictureBox20;
        public System.Windows.Forms.PictureBox pictureBox21;
        public System.Windows.Forms.PictureBox pictureBox22;
        public System.Windows.Forms.PictureBox pictureBox23;
        public System.Windows.Forms.PictureBox pictureBox24;
        public System.Windows.Forms.PictureBox pictureBox25;
        public System.Windows.Forms.PictureBox pictureBox26;
        public System.Windows.Forms.PictureBox pictureBox27;
        public System.Windows.Forms.PictureBox pictureBox28;
        public System.Windows.Forms.PictureBox pictureBox29;
        public System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
