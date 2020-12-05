using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab_5.Test
{
    public partial class Task1 : UserControl
    { 
        public Task1()
        {
            InitializeComponent();
            rand = new Random();
            timer1.Interval = rand.Next(3000, 7000);
            watch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (z == 6)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Enabled = false;
                this.Visible = false;
            }
            else
            {
                timer1.Stop();
                this.BackColor = Color.LightSeaGreen;
                watch.Start();
            }
        }

        private void UserControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            watch.Stop();
            TimeSpan t = watch.Elapsed; 
            Console.WriteLine(t.Milliseconds);
            this.BackColor = Color.DimGray;
            watch.Reset();
            timer1.Start();
            z++;
        }
    }
}
