namespace laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLadoA_Click(object sender, EventArgs e)
        {

        }

        private void lblLadoB_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtBoxLadoA.Clear();
            txtBoxLadoB.Clear();
            txtBoxLadoC.Clear();
            txtBoxSemiperimetro.Clear();
            TxtBoxAreaTriangulo.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(txtBoxLadoA.Text);
                double ladoB = Convert.ToDouble(txtBoxLadoB.Text);
                double ladoC = Convert.ToDouble(txtBoxLadoC.Text);
                if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
                {
                    MessageBox.Show("Los lados deben ser mayores que 0");
                    return;
                }
                double semiperimetro = (ladoA + ladoB + ladoC) / 2;
                txtBoxSemiperimetro.Text = semiperimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void txtBoxCalcularPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(txtBoxLadoA.Text);
                double ladoB = Convert.ToDouble(txtBoxLadoB.Text);
                double ladoC = Convert.ToDouble(txtBoxLadoC.Text);

                if ( ladoA + ladoB <= ladoC || ladoA + ladoC <= ladoB || ladoB + ladoC <= ladoA)
                {
                                        MessageBox.Show("Los valores ingresados no forman un triángulo válido.");
                    return;
                }
                double semiperimetro = (ladoA + ladoB + ladoC) / 2;

                double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

                TxtBoxAreaTriangulo.Text = area.ToString("F2");


            
            } catch
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.");
            }
        }

        private void TxtBoxAreaTriangulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
