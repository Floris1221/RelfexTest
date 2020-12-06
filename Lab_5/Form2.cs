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
    public partial class Form2 : Form
    {
        public Form2(Form1 gl)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zadanie == 1)
            {
                this.task1 = new Task11(this);
                task1.Show();
                this.Visible = false;
                zadanie++;
                label1.BackColor = Color.LightSeaGreen;
                label1.BorderStyle = BorderStyle.None;
                label2.BorderStyle = BorderStyle.Fixed3D;
                label5.Text = "Zadanie drugie polega na wciśnięcia odpowiedniego \n klawisza zgodnie" +
                    " ze wskazaniem zielonej strzałki odpowiednio: \n" +
                    " w-strzałka do góry, s-strzałka dół, a-strzałka w lewo, \n d-strzałka w prawo. Pierwsze trzy próby są instruktażowe \n i nie liczą się do wyniku końcowego";

            }
            else if(zadanie == 2)
            {
                this.task2 = new Task22(this);
                task2.Show();
                this.Visible = false;
                zadanie++;
                label2.BackColor = Color.LightSeaGreen;
                label2.BorderStyle = BorderStyle.None;
                label3.BorderStyle = BorderStyle.Fixed3D;
                label5.Text = "Zadanie trzecie polega na znalezienie odpowiedniej \n figury o kolorze " +
                    "zielonym i naciśnięciu na niej myszką.\n Pierwsze trzy próby są instruktażowe\n i nie liczą się do wyniku końcowego";
            }
            else if(zadanie == 3)
            {
                this.task3 = new Task33(this);
                task3.Show();
                this.Visible = false;
                zadanie++;
                label3.BackColor = Color.LightSeaGreen;
                label3.BorderStyle = BorderStyle.None;
                label4.BorderStyle = BorderStyle.Fixed3D;
                label5.Text = "Zadanie czwarte polega na wcisnięciu dowolnego klawisza z klawiatury \n  w momencie usłyszenia" +
                    "dzwieku systemowego. Pierwsze trzy próby są \n instruktażowe i nie liczą się do wyniku końcowego ";
            }
            else if(zadanie == 4)
            {
                this.task4 = new Task44(this);
                task4.Show();
                this.Visible = false;
                zadanie++;
                label4.BackColor = Color.LightSeaGreen;
                label4.BorderStyle = BorderStyle.None;
                label5.Text = "Koniec Testu. Wciśnij przycisk aby zobaczyć wyniki";
                button1.Text = "WYNIKI";
            }
        }//button1_Click
    }//Form2
}///Lab_5
