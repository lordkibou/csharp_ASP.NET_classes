using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_Security_Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Encriptar la contraseña para comparar con la almacenada en la base de datos
            password = GetMd5Hash(password);

            // Validar las credenciales
            if (ValidarCredenciales(username, password))
            {
                // Guardar en la sesión
                Session["Username"] = username;
                string user = ObtenerPerfil(username);
                Session["Profile"] = user;

                // Redirigir a otra página después del inicio de sesión exitoso
                Response.Redirect("UnsecuredPage.aspx");
            }
            else
            {
                // Manejar el caso en que las credenciales no sean válidas
                // Puedes mostrar un mensaje de error o realizar alguna acción adicional
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }


        // Función para validar las credenciales del usuario en la base de datos
        private bool ValidarCredenciales(string username, string password)
        {
            try
            {
                string pathDB = Server.MapPath("~/authDB.db");
                // Establecer la conexión a la base de datos SQLite
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" +
                pathDB + ";Version=3;"))
                {
                    conn.Open();

                    // Crear el comando SQL para buscar el usuario en la base de datos
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        // Añadir parámetros para evitar SQL injection
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Ejecutar el comando y obtener el resultado
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Verificar si el usuario y la contraseña coinciden
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la validación de credenciales
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

        // Función para obtener el perfil de un usuario
        private string ObtenerPerfil(string username)
        {
            try
            {
                string pathDB = Server.MapPath("~/authDB.db");
                // Establecer la conexión a la base de datos SQLite
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=" +
                pathDB + ";Version=3;"))
                {
                    conn.Open();

                    // Crear el comando SQL para obtener el perfil del usuario
                    string query = "SELECT profile FROM users WHERE username = @username";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        // Añadir parámetros para evitar SQL injection
                        command.Parameters.AddWithValue("@username", username);

                        // Ejecutar el comando y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Devolver el perfil como cadena si se encontró, de lo contrario, devolver cadena vacía

                        return result != null ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir al obtener el perfil
                // Puedes registrar el error, mostrar un mensaje de error, etc.
                return string.Empty;
            }
        }
    }
}