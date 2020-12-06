using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Task44 : Form
    {
        public Task44(Form2 fr)
        {
            InitializeComponent();
            this.fr = fr;
            int i = rand.Next(3000, 7000);
            timer1.Interval = i;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = null;
            if (podejscie == 8)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Close();
                fr.Visible = true;
            }
            else if (podejscie == 3)
            {
                timer1.Stop();
                label1.Visible = true;
                button1.Visible = true;
                podejscie++; ;
            }
            else
            {
                timer1.Stop();
                watch.Start();
                SystemSounds.Beep.Play();
            }
            if (blad == 2)
            {
                this.Close();
                fr.Visible = true;
            }
        }

        private void Task44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (watch.IsRunning)
            {
                watch.Stop();
                podejscie++;
                label2.Text = "Dobrze";
                if (podejscie > 3)
                {
                    fr.seria4[proba] = watch.ElapsedMilliseconds;
                    proba++;
                }
            }
            else
            {
                if (podejscie > 3)
                {
                    if(blad==0)
                     MessageBox.Show("Błąd. Pozostała ostatnia próba. Zacznij od nowa. Przed Tobą ponownie 3 próby instruktarzowe.");
                    else
                     MessageBox.Show("Błąd. To była ostatnia próba. Test niezaliczony");
                    blad++;
                }
                else
                {
                    MessageBox.Show("Błąd. Zacznij instruktarz od nowa");
                }
                podejscie = 0;
                proba = 0;
                label2.Text = "Błąd";
            }
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
