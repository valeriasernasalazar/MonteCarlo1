using MonteCarlo.Algoritmos;

namespace MonteCarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los numeros ingresados deben ser mayores a cero, NO pueden ser espacios en blanco.");
                return;
            }

            // segundo if para que los paramaetros de paneles sea maximo 5
            if(Convert.ToInt32(textBox2.Text) > 6)
            {
                MessageBox.Show("Numero Máximo de paneles excedido");
                return;
            }


            // Inicialización de parámetros

            int rows = Convert.ToInt32(textBox1.Text); // Numero de experimentos
            int cols = Convert.ToInt32(textBox2.Text); // Numero de paneles
            double lim_inf = Convert.ToDouble(textBox3.Text);
            double lim_sup = Convert.ToDouble(textBox4.Text);

            SimulacionMonteCarlo simulacion = new SimulacionMonteCarlo(); // se crea una instancia de la clase
            (double avg, double var) = simulacion.Algoritmo(rows, cols, lim_inf, lim_sup);

            MessageBox.Show($"Promedio: {avg}\nVarianza: {var}"); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}