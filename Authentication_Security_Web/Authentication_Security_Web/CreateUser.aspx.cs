using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace Authentication_Security_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Clear existing items (if any)
                ProfileDropDown.Items.Clear();

                // Add items to the dropdown list
                ProfileDropDown.Items.Add(new System.Web.UI.WebControls.ListItem("admin", "admin"));
                ProfileDropDown.Items.Add(new System.Web.UI.WebControls.ListItem("user", "user"));

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            string profile = ProfileDropDown.SelectedValue;

            // Encriptar la contraseña usando MD5
            password = GetMd5Hash(password);

            // Llamada a la función para crear el usuario en la base de datos
            if (CrearNuevoUsuario(username, password, profile))
            {
                // Redirigir a otro webform si se creó correctamente
                Response.Redirect("Login.aspx");
            }
            else
            {
                // Manejar el caso en el que no se pudo crear el usuario
                // Puedes mostrar un mensaje de error o realizar alguna acción adicional
            }
        }

        // Función para crear un nuevo usuario en la base de datos
        private bool CrearNuevoUsuario(string username, string password, string profile)
        {
            try
            {
                string pathDB = Server.MapPath("~/authDB.db");
                // Establecer la conexión a la base de datos SQLite
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" +
                pathDB + ";Version=3;"))
                {
                    conn.Open();

                    // Crear el comando SQL para insertar un nuevo usuario
                    string query = "INSERT INTO users (username, password, profile) VALUES (@username, @password, @profile)";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        // Añadir parámetros para evitar SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@profile", profile);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }
                }

                // El usuario se creó correctamente
                return true;
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la creación del usuario
                // Puedes registrar el error, mostrar un mensaje de error, etc.
                return false;
            }
        }
        // Función para obtener el hash MD5 de una cadena
        private string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}