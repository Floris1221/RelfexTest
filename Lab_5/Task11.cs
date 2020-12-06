using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Task11 : Form
    {
        public Task11(Form2 fr)
        {
            InitializeComponent();
            this.fr = fr;
            watch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (z == 8)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Close();
                fr.Visible = true;
            }
            else if (z == 3)
            {
                timer1.Stop();
                label1.Visible = true;
                button1.Visible = true;
                z++;
            }
            else
            {
                timer1.Stop();
                this.BackColor = Color.LightSeaGreen;
                watch.Start();
            }
            if (blad == 2)
            {
                this.Close();
                fr.Visible = true;
            }
        }

        private void Task11_KeyPress(object sender, KeyPressEventArgs e)
        {
            watch.Stop();
            if (this.BackColor==Color.LightSeaGreen)
            {
                z++;
                if (z > 3)
                {
                    fr.seria1[proba] = watch.ElapsedMilliseconds;
                    proba++;
                }
            }
            else
            {
                if(z>3)
                {
                    if(blad==0)
                    MessageBox.Show("Błąd. Pozostała ostatnia próba. Zacznij od nowa. Przed Tobą ponownie 3 próby instruktarzowe.");
                    else
                        MessageBox.Show("Błąd. To była ostatnia próba. Test niezaliczony");
                    blad++;
                    z = 0;
                    proba = 0;
                }
                else
                {
                    MessageBox.Show("Błąd. Zacznij instruktarz od nowa");
                }
                z = 0;
                proba = 0;
            }
            this.BackColor = Color.DimGray;
            watch.Reset();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Visible = false;
            button1.Visible = false;
            this.Focus();
        }
    }
}
