using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio20_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar mensajes previos y ListBox
                lblError.Text = "";
                lblError.Visible = false;
                ListBox1.Items.Clear();

                // Validar que el TextBox no esté vacío
                if (string.IsNullOrWhiteSpace(TextBox1.Text))
                {
                    throw new ArgumentException("Por favor ingrese la dimensión N de la matriz");
                }

                // Validar que sea un número entero
                if (!int.TryParse(TextBox1.Text, out int n))
                {
                    throw new FormatException("Por favor ingrese un número entero válido");
                }

                // Validar que N sea positivo y razonable
                if (n <= 0)
                {
                    throw new ArgumentException("La dimensión N debe ser un número positivo");
                }

                if (n > 20)
                {
                    throw new ArgumentException("La dimensión N no puede ser mayor a 20 por razones de visualización");
                }

                // Generar y mostrar la matriz
                GenerarMatrizDiagonalInversa(n);

            }
            catch (ArgumentException ex)
            {
                MostrarError(ex.Message);
            }
            catch (FormatException ex)
            {
                MostrarError($"Error de formato: {ex.Message}");
            }
            catch (Exception ex)
            {
                MostrarError($"Error inesperado: {ex.Message}");
            }
        }

        private void GenerarMatrizDiagonalInversa(int n)
        {
            // Limpiar el ListBox
            ListBox1.Items.Clear();

            // Agregar encabezado
            ListBox1.Items.Add($"=== MATRIZ {n}xn - DIAGONAL INVERSA ===");
            ListBox1.Items.Add("");

            // Generar la matriz
            for (int i = 0; i < n; i++)
            {
                string fila = "";
                for (int j = 0; j < n; j++)
                {
                    // La diagonal inversa tiene índices donde i + j = n - 1
                    if (i + j == n - 1)
                    {
                        fila += "1 ";
                    }
                    else
                    {
                        fila += "0 ";
                    }
                }
                ListBox1.Items.Add(fila.Trim());
            }

            // Hacer visible el ListBox
            ListBox1.Visible = true;
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }
    }
}