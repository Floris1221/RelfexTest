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
    public partial class Task2 : UserControl
    {
        public Task2()
        {
            InitializeComponent();
            rand = new Random();
            timer1.Interval = rand.Next(3000, 7000);
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            //wczytanie srzałek
            black_arrow = Image.FromFile("C:\\Users\\Acer\\OneDrive\\Pulpit\\Arrow.png");
            green_arrow = Image.FromFile("C:\\Users\\Acer\\OneDrive\\Pulpit\\Green_Arrow.png");
            red_arrow = Image.FromFile("C:\\Users\\Acer\\OneDrive\\Pulpit\\Red_Arrow.png");
            bmp_r_d = new Bitmap(red_arrow, 70, 70);


            //Wszystkie możliwości dla czarnej strzałki
            bmp_b_d = new Bitmap(black_arrow, 70, 70);
            bmp_b_u = new Bitmap(black_arrow, 70, 70);
            bmp_b_u.RotateFlip(RotateFlipType.Rotate180FlipX);
            bmp_b_l = new Bitmap(black_arrow, 70, 70);
            bmp_b_l.RotateFlip(RotateFlipType.Rotate270FlipX);
            bmp_b_r = new Bitmap(black_arrow, 70, 70);
            bmp_b_r.RotateFlip(RotateFlipType.Rotate90FlipX);


            //Wczytanie ekranu początkowego
            this.panel1.BackgroundImage = bmp_b_u;
            this.panel2.BackgroundImage = bmp_b_d;
            this.panel3.BackgroundImage = bmp_b_r;
            this.panel4.BackgroundImage = bmp_b_l;

            //Wszystkie możliwości dla zielonej strzałki
            bmp_g_r = new Bitmap(green_arrow, 70, 70);
            bmp_g_l = new Bitmap(green_arrow, 70, 70);
            bmp_g_l.RotateFlip(RotateFlipType.Rotate180FlipY);
            bmp_g_d = new Bitmap(green_arrow, 70, 70);
            bmp_g_d.RotateFlip(RotateFlipType.Rotate270FlipY);
            bmp_g_u = new Bitmap(green_arrow, 70, 70);
            bmp_g_u.RotateFlip(RotateFlipType.Rotate90FlipY);

            //Wszystkie możliwości dla czerwonej strzałki
            bmp_r_d = new Bitmap(red_arrow, 70, 70);
            bmp_r_u = new Bitmap(red_arrow, 70, 70);
            bmp_r_u.RotateFlip(RotateFlipType.Rotate180FlipX);
            bmp_r_l = new Bitmap(red_arrow, 70, 70);
            bmp_r_l.RotateFlip(RotateFlipType.Rotate270FlipX);
            bmp_r_r = new Bitmap(red_arrow, 70, 70);
            bmp_r_r.RotateFlip(RotateFlipType.Rotate90FlipX);

            /*
            this.panel1.BackgroundImage = bmp_g_u;
            this.panel2.BackgroundImage = bmp_g_d;
            this.panel3.BackgroundImage = bmp_g_r;
            this.panel4.BackgroundImage = bmp_g_l;
            */


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            int x = rand.Next(3);
            int y;
            do
            {
                y = rand.Next(3);
            } while (y == x);

            //Pierwsza zmiana

            if (x == 0)
            {
                this.panel1.BackgroundImage = bmp_g_u;
            }
            else if(x == 1)
            {
                this.panel2.BackgroundImage = bmp_g_d;
            }
            else if (x == 2)
            {
                this.panel3.BackgroundImage = bmp_g_r;
            }
            else if (x == 3)
            {
                this.panel4.BackgroundImage = bmp_g_l;
            }

            //Druga zmiana

            if (y == 0)
            {
                this.panel1.BackgroundImage = bmp_r_u;
            }
            else if (y == 1)
            {
                this.panel2.BackgroundImage = bmp_r_d;
            }
            else if (y == 2)
            {
                this.panel3.BackgroundImage = bmp_r_r;
            }
            else if (y == 3)
            {
                this.panel4.BackgroundImage = bmp_r_l;
            }

            watch.Start();







        }//Timer

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            if ((panel1.BackgroundImage == bmp_g_u && e.KeyChar=='w') || (panel2.BackgroundImage == bmp_g_d && e.KeyChar == 's') || (panel3.BackgroundImage == bmp_g_r && e.KeyChar == 'd') || (panel4.BackgroundImage == bmp_g_l && e.KeyChar == 'a'))
            {
                podejscie++;
            }
            else
            {
                podejscie = 0;
                MessageBox.Show("Błąd. Zacznij od nowa");
            }

            watch.Stop();

            //Ustawienie poczatkowe
            this.panel1.BackgroundImage = bmp_b_u;
            this.panel2.BackgroundImage = bmp_b_d;
            this.panel3.BackgroundImage = bmp_b_r;
            this.panel4.BackgroundImage = bmp_b_l;
            timer1.Start();

        }




    }//Task2
}//pacage
