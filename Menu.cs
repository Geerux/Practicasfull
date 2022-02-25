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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sumaDeDosNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sum2 ac = new Sum2();
            ac.Show();
     
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void promedioDe3CalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promedio3 oc = new Promedio3();
            oc.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora ez = new Calculadora();
            ez.Show();
        }

        private void arraysBidemensionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayMu al = new ArrayMu();
            al.Show();
        }
    }
}
