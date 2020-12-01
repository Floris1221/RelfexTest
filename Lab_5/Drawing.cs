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
        private Color[] colors = { Color.Red, Color.DarkKhaki, Color.Yellow };
        public Drawing()
        {
            nr = q;
            q++;
        }
        public Bitmap draw(int x,Task3 task)
        {
            if(task.zielony == nr)
            {
                color = Color.LightSeaGreen;
            }
            else
            {
                int i = rand.Next(2);
                color = colors[i];
            }
            int width = task.pictureBox1.Width;
            int height = task.pictureBox1.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);
            Bitmap bmp = new Bitmap(width + 1, height + 1);
            Graphics g;
            SolidBrush brush = new SolidBrush(color);
            if (x == 0)
            {
                g = Graphics.FromImage(bmp);
                g.FillRectangle(brush, rect);

            }else if (x == 1)
            {
                g = Graphics.FromImage(bmp);
                g.FillEllipse(brush,rect);
            }else if (x == 2)
            {
                Point point1 = new Point(0, height);
                Point point2 = new Point(width, height);
                Point point3 = new Point(width / 2, 0);
                Point[] points = {point1,point2,point3 };
                g = Graphics.FromImage(bmp);
                g.FillPolygon(brush, points);
            }else if (x == 3)
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
