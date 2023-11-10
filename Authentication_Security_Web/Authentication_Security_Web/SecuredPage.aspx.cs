using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_Security_Web
{
    public partial class WebForm4 : System.Web.UI.Page
    {

        // Esta función verifica si hay un usuario en la sesión
        private bool HayUsuarioEnSesion()
        {
            return Session["Username"] != null;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Registra un script JavaScript para imprimir en la consola del navegador
            string script = $"console.log('{Session["Username"]} {Session["Profile"]}');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "PrintToConsole", script, true);

            if (!HayUsuarioEnSesion())
            {
                Response.Redirect("Login.aspx");
            }
            
            UserLabel.Text = ObtenerUsernameDeSesion();
        }

        // Esta función obtiene el nombre de usuario de la sesión y lo devuelve como cadena
        private string ObtenerUsernameDeSesion()
        {
            return Session["Username"] != null ? Session["Username"].ToString() : string.Empty;
        }

        // Esta función cierra la sesión y redirige a otra página
        private void CerrarSesionYRedirigir(string paginaDestino)
        {
            // Limpiar la sesión
            Session["Username"] = null;

            Session["Profile"] = null;

            // Redirigir a otra página
            Response.Redirect(paginaDestino);
        }

        protected void SignOutButton_Click(object sender, EventArgs e)
        {
            CerrarSesionYRedirigir("Login.aspx");
        }
    }
}