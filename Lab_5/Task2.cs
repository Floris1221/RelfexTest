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

            //Przypożadkowanie do tablic
            Bitmap[] up = { bmp_b_u , bmp_b_u , bmp_r_u };
            Bitmap[] downn = { bmp_b_d, bmp_b_d, bmp_r_d };
            Bitmap[] right = { bmp_b_r, bmp_b_r, bmp_r_r };
            Bitmap[] left = { bmp_b_l, bmp_b_l, bmp_r_l };

            /*
            this.panel1.BackgroundImage = bmp_g_u;
            this.panel2.BackgroundImage = bmp_g_d;
            this.panel3.BackgroundImage = bmp_g_r;
            this.panel4.BackgroundImage = bmp_g_l;
            */

            this.timer1.Interval = rand.Next(3000, 7000);


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
        }
    }
}
