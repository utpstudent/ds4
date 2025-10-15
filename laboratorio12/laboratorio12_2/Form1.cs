namespace laboratorio12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNota2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtBoxNota1.Clear();
            txtBoxNota2.Clear();
            txtBoxNota3.Clear();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(txtBoxNota1.Text);
                double nota2 = Convert.ToDouble(txtBoxNota2.Text);
                double nota3 = Convert.ToDouble(txtBoxNota3.Text);
                if (nota1 < 0 || nota1 > 100 || nota2 < 0 || nota2 > 100 || nota3 < 0 || nota3 > 100)
                {
                    MessageBox.Show("Las notas deben estar entre 0 y 100");
                    return;
                }
                double promedio = (nota1 + nota2 + nota3) / 3;
                txtBoxNotaPromedio.Text = promedio.ToString("F2");

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para las notas.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}

