using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Lab_5
{
    partial class Task33
    {
        /// <summary>
        Random rand = new Random();
        Stopwatch watch = new Stopwatch();
        public int zielony;
        public int figura;
        PictureBox[] picbox;
        int podejscie = 0;
        int proba = 0;
        String s;
        Form2 fr;
        int blad = 0;

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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(427, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 32;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(1075, 613);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(153, 113);
            this.pictureBox18.TabIndex = 30;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(884, 613);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(153, 113);
            this.pictureBox25.TabIndex = 29;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(671, 613);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(153, 113);
            this.pictureBox20.TabIndex = 28;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(457, 613);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(153, 113);
            this.pictureBox15.TabIndex = 27;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(236, 613);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(153, 113);
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(12, 613);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(153, 113);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(1075, 477);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(153, 113);
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(884, 477);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(153, 113);
            this.pictureBox24.TabIndex = 23;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(671, 477);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(153, 113);
            this.pictureBox19.TabIndex = 22;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(457, 477);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(153, 113);
            this.pictureBox14.TabIndex = 21;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(236, 477);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(153, 113);
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 477);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 113);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(1075, 323);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(153, 113);
            this.pictureBox28.TabIndex = 18;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(1075, 173);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(153, 113);
            this.pictureBox27.TabIndex = 31;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(884, 323);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(153, 113);
            this.pictureBox23.TabIndex = 2;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(884, 173);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(153, 113);
            this.pictureBox22.TabIndex = 15;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(671, 173);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(153, 113);
            this.pictureBox17.TabIndex = 13;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(1075, 22);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(153, 113);
            this.pictureBox26.TabIndex = 11;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(457, 173);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(153, 113);
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(884, 22);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(153, 113);
            this.pictureBox21.TabIndex = 9;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(236, 323);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(153, 113);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(671, 22);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(153, 113);
            this.pictureBox16.TabIndex = 7;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(236, 173);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(153, 113);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(457, 22);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(153, 113);
            this.pictureBox11.TabIndex = 5;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 113);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(236, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(153, 113);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 113);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 113);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(216, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(809, 88);
            this.label2.TabIndex = 34;
            this.label2.Text = "To były trzy próby instruktarzowe. \r\nWciśnij START aby rozpocząć próbe właściwą.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(420, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 147);
            this.button1.TabIndex = 33;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox17);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task33";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task33";
            this.Load += new System.EventHandler(this.Task33_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox18;
        public System.Windows.Forms.PictureBox pictureBox25;
        public System.Windows.Forms.PictureBox pictureBox20;
        public System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.PictureBox pictureBox24;
        public System.Windows.Forms.PictureBox pictureBox19;
        public System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox28;
        public System.Windows.Forms.PictureBox pictureBox27;
        public System.Windows.Forms.PictureBox pictureBox23;
        public System.Windows.Forms.PictureBox pictureBox22;
        public System.Windows.Forms.PictureBox pictureBox17;
        public System.Windows.Forms.PictureBox pictureBox26;
        public System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.PictureBox pictureBox21;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox16;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button button1;
    }
}