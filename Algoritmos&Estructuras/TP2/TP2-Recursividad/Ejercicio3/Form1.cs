using Microsoft.VisualBasic;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Escribir una funci�n recursiva que resuelva N a la p donde N y p son n�meros positivos.
        public int Potencia(int N, int p)
        {
            if (p == 0)
            {
                return 1;
            }
            else
            {
                return N * Potencia(N, p - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Interaction.InputBox("Ingrese la base: "));
            int p = Convert.ToInt32(Interaction.InputBox("Ingrese el exponente: "));

            int pot = Potencia(n, p);
            MessageBox.Show("N a la P = "+pot);
        }
    }
}
