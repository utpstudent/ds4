namespace laboratorio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double velocidad = Convert.ToDouble(txtBoxVelocidad.Text);
                int segundos = Convert.ToInt32(txtBoxSegundos.Text);
                double distancia = velocidad * segundos;
                txtBoxResultado.Text = distancia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para velocidad y tiempo.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Los valores ingresados son demasiado grandes. Por favor, ingrese valores más pequeños.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxVelocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSegundos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtBoxVelocidad.Clear();
            txtBoxSegundos.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
