namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Algoritmo
        string[,] Ejercicio2()
        {
            string[,] matriz;
            matriz = new string[5, 5]{
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" },
            { "-", "-", "-", "-", "-" }
            }; 

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i+j == 4) matriz[i, j] = "*";
                }
            }
            return matriz;
        }

        // Impresion de la matriz
        private void button1_Click(object sender, EventArgs e)
        {
            string[,] matriz = Ejercicio2();
            listView1.Items.Clear();
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    listView1.Items.Add(matriz[i, j]);
                }
            }
        }
    }
}