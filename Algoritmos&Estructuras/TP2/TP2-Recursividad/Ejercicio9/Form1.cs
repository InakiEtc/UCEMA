using Microsoft.VisualBasic;
using System.Numerics;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Programe un m�todo recursivo que transforme un n�mero entero positivo a notaci�n binaria.
        private string DecimalToBinario(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            else if (num == 1)
            {
                return "1";
            }
            else
            {
                return DecimalToBinario(num / 2) + (num % 2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Interaction.InputBox("Ingrese numero a pasar"));
            string binario = DecimalToBinario(num);
            MessageBox.Show("El numero " + num + " en binario es: " + binario);
        }
    }
}
