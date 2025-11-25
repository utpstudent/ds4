using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio20_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = @"Server=.\sqlexpress;Database=Productos;TrustServerCertificate=true;Integrated Security=SSPI;";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Estado inicial del formulario
                SetFormState(false, false, false, false, false, true, false, false, false);
                ClearForm();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            SetFormState(false, true, true, false, false, false, true, true, true);
            ClearForm();
            txtNombre.Focus();
            ViewState["nuevo"] = true;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esNuevo = ViewState["nuevo"] != null ? (bool)ViewState["nuevo"] : true;

            if (esNuevo)
            {
                // INSERTAR NUEVO REGISTRO
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@Nombre, @Precio, @Stock)";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));

                        try
                        {
                            con.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                lblMensaje.Text = "Registro ingresado correctamente!";
                                lblMensaje.CssClass = "alert alert-success";
                            }
                        }
                        catch (Exception ex)
                        {
                            lblMensaje.Text = "Error: " + ex.Message;
                            lblMensaje.CssClass = "alert alert-danger";
                        }
                    }
                }
            }
            else
            {
                // ACTUALIZAR REGISTRO EXISTENTE
                string sql = "UPDATE LAPTOPS SET NOMBRE = @Nombre, PRECIO = @Precio, STOCK = @Stock WHERE ID = @Id";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                        cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));

                        try
                        {
                            con.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                lblMensaje.Text = "Registro actualizado correctamente!";
                                lblMensaje.CssClass = "alert alert-success";
                            }
                        }
                        catch (Exception ex)
                        {
                            lblMensaje.Text = "Error: " + ex.Message;
                            lblMensaje.CssClass = "alert alert-danger";
                        }
                    }
                }
            }

            // Restablecer estado del formulario
            SetFormState(true, false, false, false, false, true, false, false, false);
            ClearForm();
            lblMensaje.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            SetFormState(true, false, false, false, false, true, false, false, false);
            ClearForm();
            lblMensaje.Visible = false;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM LAPTOPS WHERE ID = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));

                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            lblMensaje.Text = "Registro eliminado correctamente!";
                            lblMensaje.CssClass = "alert alert-success";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error: " + ex.Message;
                        lblMensaje.CssClass = "alert alert-danger";
                    }
                }
            }

            SetFormState(true, false, false, false, false, true, false, false, false);
            ClearForm();
            lblMensaje.Visible = true;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LAPTOPS WHERE ID = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txtBuscarId.Text));

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Llenar el formulario con los datos
                            txtId.Text = reader["ID"].ToString();
                            txtNombre.Text = reader["NOMBRE"].ToString();
                            txtPrecio.Text = reader["PRECIO"].ToString();
                            txtStock.Text = reader["STOCK"].ToString();

                            // Cambiar estado del formulario
                            SetFormState(false, true, true, true, false, false, true, true, true);
                            ViewState["nuevo"] = false;
                            lblMensaje.Visible = false;
                        }
                        else
                        {
                            lblMensaje.Text = "Ningún registro encontrado con el ID ingresado!";
                            lblMensaje.CssClass = "alert alert-warning";
                            lblMensaje.Visible = true;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error: " + ex.Message;
                        lblMensaje.CssClass = "alert alert-danger";
                        lblMensaje.Visible = true;
                    }
                }
            }
            txtBuscarId.Text = "";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            // En una aplicación web, "salir" podría redirigir a otra página o cerrar sesión
            // Para simular el cierre, redirigimos a una página vacía o mostramos mensaje
            lblMensaje.Text = "Aplicación finalizada";
            lblMensaje.CssClass = "alert alert-info";
            lblMensaje.Visible = true;
        }

        // Método auxiliar para establecer el estado del formulario
        private void SetFormState(bool nuevoBtn, bool guardarBtn, bool cancelarBtn, bool eliminarBtn,
                                bool idEnabled, bool buscarEnabled, bool nombreEnabled,
                                bool precioEnabled, bool stockEnabled)
        {
            btnNuevo.Enabled = nuevoBtn;
            btnGuardar.Enabled = guardarBtn;
            btnCancelar.Enabled = cancelarBtn;
            btnEliminar.Enabled = eliminarBtn;
            txtId.Enabled = idEnabled;
            txtBuscarId.Enabled = buscarEnabled;
            btnBuscar.Enabled = buscarEnabled;
            txtNombre.Enabled = nombreEnabled;
            txtPrecio.Enabled = precioEnabled;
            txtStock.Enabled = stockEnabled;
        }

        // Método auxiliar para limpiar el formulario
        private void ClearForm()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtBuscarId.Text = "";
        }
    }
}