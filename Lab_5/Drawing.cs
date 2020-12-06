using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Drawing
    {
        private static int q = 0;
        private int nr;
        private Color color;
        private Random rand = new Random();
        private Color[] colors = { Color.Red, Color.DarkKhaki, Color.Yellow, Color.LightSeaGreen };
        public Drawing()
        {
            nr = q;
            q++;
        }
        public Bitmap draw(Task33 task,int i, int j)
        {
            if(task.zielony == nr)
            {
                color = Color.LightSeaGreen;
                i = task.figura;

            }
            else
            {
                color = colors[j];
                if(color==Color.LightSeaGreen && i == task.figura)
                {
                    int z = rand.Next(3);
                    color = colors[z];
                }
                
            }
            int width = task.pictureBox1.Width;
            int height = task.pictureBox1.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);
            Bitmap bmp = new Bitmap(width + 1, height + 1);
            Graphics g;
            SolidBrush brush = new SolidBrush(color);
            if (i == 0)
            {
                g = Graphics.FromImage(bmp);
                g.FillRectangle(brush, rect);

            }else if (i == 1)
            {
                g = Graphics.FromImage(bmp);
                g.FillEllipse(brush,rect);
            }else if (i == 2)
            {
                Point point1 = new Point(0, height);
                Point point2 = new Point(width, height);
                Point point3 = new Point(width / 2, 0);
                Point[] points = {point1,point2,point3 };
                g = Graphics.FromImage(bmp);
                g.FillPolygon(brush, points);
            }else if (i == 3)
            {
                Point point1 = new Point(width / 2, 0);
                Point point2 = new Point(width, height/2);
                Point point3 = new Point((width/4)*3,height);
                Point point4 = new Point(width/4,height);
                Point point5 = new Point(0,height/2);
                Point[] points = { point1, point2, point3,point4,point5 };
                g = Graphics.FromImage(bmp);
                g.FillPolygon(brush, points);

            }

            return bmp;
        }

    }
}
