using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_Security_Web
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        // Esta función verifica si hay un usuario en la sesión
        private bool HayUsuarioEnSesionyEsAdmin()
        {
            // Registra un script JavaScript para imprimir en la consola del navegador
            string script = $"console.log('{Session["Username"]} {Session["Profile"] is string}');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "PrintToConsole", script, true);

            if (Session["Profile"].ToString() != "admin")
            {
                return false;
            }
            return true;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!HayUsuarioEnSesionyEsAdmin())
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void SignOutAdminButton_Click(object sender, EventArgs e)
        {
            CerrarSesionYRedirigir("Login.aspx");
        }
    }
}