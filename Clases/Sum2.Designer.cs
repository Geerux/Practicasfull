namespace Practicasfull
{
    partial class Sum2
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        class CLCALCULA
        {
            // CAMPOS C, C++, C#, JAVA, JAVASCRIPT, PHP
            private double numero1;
            private double numero2;
            //public double resultado;
            // Constructor
            public CLCALCULA(double numero1, double numero2)
            {
                this.numero1 = numero1;
                this.numero2 = numero2;
            }

            public double Numero1 { get => numero1; set => numero1 = value; }
            public double Numero2 { get => numero2; set => numero2 = value; }

            public double fsumar()
            {
                return (numero1 + numero2);
            }
            public double fmultiplicar()
            {
                return (numero1 * numero2);
            }
            public double fdividir()
            {
                return (numero1 / numero2);
            }
            public double frestar()
            {
                return (numero1 - numero2);
            }
            //public void psumar()
            //{
            //    resultado = numero1 + numero2;
            //}
        }
    }
}