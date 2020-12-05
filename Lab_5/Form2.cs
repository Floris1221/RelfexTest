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
                this.panel1.Visible = false;
                task11.Visible = true;
                task11.Enabled = true;
                zadanie++;
            }
        }
    }
}
