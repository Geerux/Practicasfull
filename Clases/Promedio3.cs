using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicasfull
{
    public partial class Promedio3 : Form
    {
        public Promedio3()
        {
            InitializeComponent();
        }

        private void Promedio3_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cali1 = 0;
            int cali2 = 0;
            int cali3 = 0;
            double promedio = 0;

            cali1 = int.Parse(txtcali1.Text);
            cali2 = int.Parse(txtcali2.Text);
            cali3 = int.Parse(txtcali3.Text);

            promedio = (cali1 + cali2 + cali3) / 3;

            txtpromedio.Text = promedio.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
