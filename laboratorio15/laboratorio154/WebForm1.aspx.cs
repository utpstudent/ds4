using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2;

            
            if (!int.TryParse(TextBox1.Text, out num1))
            {
                Label5.Text = "Error: el primer valor no es un número entero.";
                Label5.ForeColor = System.Drawing.Color.Red;
                return;
            }

            
            if (!int.TryParse(TextBox2.Text, out num2))
            {
                Label5.Text = "Error: el segundo valor no es un número entero.";
                Label5.ForeColor = System.Drawing.Color.Red;
                return;
            }

            
            int resultado = num1 + num2;

            
            Label5.Text =  "" + resultado;
            Label5.ForeColor = System.Drawing.Color.Black;
        }
    }
}