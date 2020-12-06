using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Wyniki : Form
    {
        public Wyniki(Form2 fr)
        {
            InitializeComponent();
            this.fr = fr;
        }

        private void Wyniki_Load(object sender, EventArgs e)
        {
            label27.ForeColor = Color.DarkGreen;
            label28.ForeColor = Color.Green;
            label29.ForeColor = Color.Yellow;
            label30.ForeColor = Color.Red;
            label31.ForeColor = Color.DarkRed;

            //Wyniki zadanie 1
            kolor(1, fr.seria1[0], label7);
            label7.Text = fr.seria1[0].ToString();
            kolor(1, fr.seria1[1], label8);
            label8.Text = fr.seria1[1].ToString();
            kolor(1, fr.seria1[2], label9);
            label9.Text = fr.seria1[2].ToString();
            kolor(1, fr.seria1[3], label10);
            label10.Text = fr.seria1[3].ToString();

            //Wyniki zadanie 2
            kolor(2, fr.seria2[0], label12);
            label12.Text = fr.seria2[0].ToString();
            kolor(2, fr.seria2[1], label13);
            label13.Text = fr.seria2[1].ToString();
            kolor(2, fr.seria2[2], label14);
            label14.Text = fr.seria2[2].ToString();
            kolor(2, fr.seria2[3], label15);
            label15.Text = fr.seria2[3].ToString();

            //Wyniki zadanie 3
            kolor(3, fr.seria3[0], label17);
            label17.Text = fr.seria3[0].ToString();
            kolor(3, fr.seria3[1], label18);
            label18.Text = fr.seria3[1].ToString();
            kolor(3, fr.seria3[2], label19);
            label19.Text = fr.seria3[2].ToString();
            kolor(3, fr.seria3[3], label20);
            label20.Text = fr.seria3[3].ToString();

            //Wyniki zadanie 4
            kolor(4, fr.seria3[0], label22);
            label22.Text = fr.seria4[0].ToString();
            kolor(4, fr.seria3[1], label23);
            label23.Text = fr.seria4[1].ToString();
            kolor(4, fr.seria3[2], label24);
            label24.Text = fr.seria4[2].ToString();
            kolor(4, fr.seria3[3], label26);
            label26.Text = fr.seria4[3].ToString();


        }

        public static void kolor(int x,long l,Label label)
        {
            if (x == 1)
            {
                if (l < 400)
                    label.ForeColor = Color.DarkGreen;
                else if(l<800)
                    label.ForeColor = Color.LightGreen;
                else if(l<1000)
                    label.ForeColor = Color.Yellow;
                else if(l<1200)
                    label.ForeColor = Color.Red;
                else if(l>=1200)
                    label.ForeColor = Color.DarkRed;
            }//if(1)
            if (x == 2)
            {
                if (l < 500)
                    label.ForeColor = Color.DarkGreen;
                else if (l < 900)
                    label.ForeColor = Color.LightGreen;
                else if (l < 1200)
                    label.ForeColor = Color.Yellow;
                else if (l < 1500)
                    label.ForeColor = Color.Red;
                else if (l >= 1500)
                    label.ForeColor = Color.DarkRed;
            }//if(2)
            if (x == 3)
            {
                if (l < 1800)
                    label.ForeColor = Color.DarkGreen;
                else if (l < 2200)
                    label.ForeColor = Color.LightGreen;
                else if (l < 3000)
                    label.ForeColor = Color.Yellow;
                else if (l < 3700)
                    label.ForeColor = Color.Red;
                else if (l >= 3700)
                    label.ForeColor = Color.DarkRed;
            }//if(3)
            if (x == 4)
            {
                if (l < 600)
                    label.ForeColor = Color.DarkGreen;
                else if (l < 900)
                    label.ForeColor = Color.LightGreen;
                else if (l < 1200)
                    label.ForeColor = Color.Yellow;
                else if (l < 1600)
                    label.ForeColor = Color.Red;
                else if (l >= 1600)
                    label.ForeColor = Color.DarkRed;
            }//if(4)

        }//kolor

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//Wyniki
}//Lab_5
