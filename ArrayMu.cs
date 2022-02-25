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
    public partial class ArrayMu : Form
    {
        public ArrayMu()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int r;
        int contador;
        int c = 0;
        private void button2_Click(object sender, EventArgs e)

        {
            contador = contador + 1; // = contador ++;
            r++;

            if (contador > (tamaño * 2)) MessageBox.Show("lleno");
            else
            {

            }
            if (r > tamaño)




                if (contador <= tamaño)
                    arreglo[contador - 1, c] = txtvalor.Text;

        }
        int tamaño = 0;
        string[,] arreglo;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            tamaño = int.Parse(txttamaño.Text);
            arreglo = new string[tamaño, 2];

        }

        private void arreglobidimensionales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
