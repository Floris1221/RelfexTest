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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test ma za zadanie sprawdzic szybkość reakcji kandydatów na kierowców kategori C/D. Badany będzie miał do wykonania kilka zadań za pośrednictwem myszki. Zadania te badany powinien wykonać w jak najkrótszym czasie. Wynik jaki uzyska będzie wyznacznikiem czy kandydat może przystąpić do kursu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.test = new Form2(this);
            this.test.Show();
        }
    }
}
