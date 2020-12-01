using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Task3 : UserControl
    {
        public Task3()
        {
            InitializeComponent();
            int zielony = 0;

        }

        private void Task3_Load(object sender, EventArgs e)
        {
            Drawing dr1 = new Drawing();
            Drawing dr2 = new Drawing();
            Drawing dr3 = new Drawing();
            Drawing dr4 = new Drawing();
            Drawing dr5 = new Drawing();
            Drawing dr6 = new Drawing();
            Drawing dr7 = new Drawing();
            Drawing dr8 = new Drawing();
            Drawing dr9 = new Drawing();
            Drawing dr10 = new Drawing();
            Drawing dr11 = new Drawing();
            Drawing dr12 = new Drawing();
            Drawing dr13 = new Drawing();
            Drawing dr14 = new Drawing();
            Drawing dr15 = new Drawing();
            Drawing dr16 = new Drawing();
            Drawing dr17 = new Drawing();
            Drawing dr18 = new Drawing();
            Drawing dr19 = new Drawing();
            Drawing dr20 = new Drawing();
            Drawing dr21 = new Drawing();
            Drawing dr22 = new Drawing();
            Drawing dr23 = new Drawing();
            Drawing dr24 = new Drawing();
            Drawing dr25 = new Drawing();
            Drawing dr26 = new Drawing();
            Drawing dr27 = new Drawing();
            Drawing dr28 = new Drawing();
            Drawing dr29 = new Drawing();
            Drawing dr30 = new Drawing();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            zielony = rand.Next(29);
        }
    }
}
