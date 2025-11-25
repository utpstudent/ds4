using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                lblError.Text = "";
                lblError.Visible = false;
                ListBox1.Items.Clear();

                
                if (string.IsNullOrWhiteSpace(TextBox1.Text))
                {
                    throw new ArgumentException("Por favor ingrese un número");
                }

                
                if (!int.TryParse(TextBox1.Text, out int factor))
                {
                    throw new FormatException("Por favor ingrese un número entero válido");
                }

                
                if (factor < -1000 || factor > 1000)
                {
                    throw new ArgumentException("Por favor ingrese un número entre -1000 y 1000");
                }

                
                GenerarTablaMultiplicar(factor);

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

        private void GenerarTablaMultiplicar(int factor)
        {
            
            ListBox1.Items.Clear();

            
            ListBox1.Items.Add($"=== TABLA DE MULTIPLICAR DEL {factor} ===");
            ListBox1.Items.Add(""); 

            
            for (int i = 1; i <= 25; i++)
            {
                int resultado = i * factor;
                string operacion = $"{i} × {factor} = {resultado}";
                ListBox1.Items.Add(operacion);
            }

            
            ListBox1.Visible = true;

            
            if (ListBox1.Items.Count > 0)
            {
                ListBox1.SelectedIndex = 0;
            }
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem != null)
            {
                string itemSeleccionado = ListBox1.SelectedItem.Text;

                
                if (lblSeleccion != null)
                {
                    lblSeleccion.Text = $"Seleccionado: {itemSeleccionado}";
                    lblSeleccion.Visible = true;
                }
            }
        }
    }
}