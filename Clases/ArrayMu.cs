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
        int r; 
        int C = 0; 
        int contador;
        private void button1_Click(object sender, EventArgs e)
        {
            contador++; 
            r++; 
            if (contador > (tamaño * 2)) MessageBox.Show("Lleno");
            else
            {



                if (r > tamaño)
                {
                    r = 1;
                    C = 1; 
                }
                if (r <= tamaño)
                    arreglo[r - 1, C] = txtvalor.Text;

            }
        }
        int tamaño = 0;
        string[,] arreglo;
        private void txttamaño_TextChanged(object sender, EventArgs e)
        {

            tamaño = int.Parse(txttamaño.Text);
            arreglo = new string[tamaño, 2];
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
          
            C = 0; 
            int r = 0; 
           
            DataGridViewRow row; 
            for (int rr = 0; rr < tamaño; rr++)
            
            {
                row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                for (int CC = 0; CC < 2; CC++)
            
                {
                    row.Cells[CC].Value = arreglo[rr, CC];

                    C++;
                }

                this.dataGridView1.Rows.Add(row);
                C = 0;
                r++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contador = 0;
            Array.Clear(arreglo, 0, arreglo.Length);
            dataGridView1.Rows.Clear();
        }

        private void arreglosbidimencionales_Load(object sender, EventArgs e)
        {

        }
    }
}
