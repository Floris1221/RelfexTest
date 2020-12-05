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
            zielony = 0;
            figura = 0;
            proba = 0;
            picbox =new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30 };
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            dr1 = new Drawing();
            dr2 = new Drawing();
            dr3 = new Drawing();
            dr4 = new Drawing();
            dr5 = new Drawing();
            dr6 = new Drawing();
            dr7 = new Drawing();
            dr8 = new Drawing();
            dr9 = new Drawing();
            dr10 = new Drawing();
            dr11 = new Drawing();
            dr12 = new Drawing();
            dr13 = new Drawing();
            dr14 = new Drawing();
            dr15 = new Drawing();
            dr16 = new Drawing();
            dr17 = new Drawing();
            dr18 = new Drawing();
            dr19 = new Drawing();
            dr20 = new Drawing();
            dr21 = new Drawing();
            dr22 = new Drawing();
            dr23 = new Drawing();
            dr24 = new Drawing();
            dr25 = new Drawing();
            dr26 = new Drawing();
            dr27 = new Drawing();
            dr28 = new Drawing();
            dr29 = new Drawing();
            dr30 = new Drawing();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (proba < 6)
            {
                timer1.Stop();
                zielony = rand.Next(30);
                figura = rand.Next(4);
                int i;
                int j;
                this.label1.Text = "Znajdź zielony " + figura.ToString() + "Jest na pozycji" + zielony.ToString();
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox1.Image = dr1.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox2.Image = dr2.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox3.Image = dr3.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox4.Image = dr4.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox5.Image = dr5.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox6.Image = dr6.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox7.Image = dr7.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox8.Image = dr8.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox9.Image = dr9.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox10.Image = dr10.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox11.Image = dr11.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox12.Image = dr12.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox13.Image = dr13.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox14.Image = dr14.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox15.Image = dr15.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox16.Image = dr16.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox17.Image = dr17.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox18.Image = dr18.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox19.Image = dr19.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox20.Image = dr20.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox21.Image = dr21.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox22.Image = dr22.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox23.Image = dr23.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox24.Image = dr24.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox25.Image = dr25.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox26.Image = dr26.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox27.Image = dr27.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox28.Image = dr28.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox29.Image = dr29.draw(this, i, j);
                i = rand.Next(4);
                j = rand.Next(4);
                pictureBox30.Image = dr30.draw(this, i, j);
                watch.Start();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Koniec!!!");
            }
        }

        private void picturebox_MouseClick(object sender, MouseEventArgs e)
        {
            watch.Stop();
            if (picbox[zielony] == sender)
            {
                proba++;
                MessageBox.Show("Dobrze");
            }
            else
            {
                proba = 0;
                MessageBox.Show("Błąd zacznij od nowa");
            }
            timer1.Start();

        }
    }
}
