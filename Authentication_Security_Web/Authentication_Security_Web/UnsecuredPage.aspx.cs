using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_Security_Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        //private bool isUserValidated;

        // Esta función verifica si hay un usuario en la sesión
        private bool HayUsuarioEnSesion()
        {
            return Session["Username"] != null;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HayUsuarioEnSesion())
            {
                BooleanResult.Text = "True";
            }
            else
            {
                BooleanResult.Text = "False";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("SecuredPage.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["Profile"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if(Session["Profile"].ToString() == "admin")
            {
                Response.Redirect("AdminPage.aspx");
            }

        }
    }
}