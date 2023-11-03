using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppInitialWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                lbMessage.Text = "Postback TRUE";

            }
            else
            {
                lbMessage.Text = "Postback FALSE";
            }
        }

        protected void btOK_Click(object sender, EventArgs e)
        {
            txtView.Text = "Hello World";
        }

        // Función para obtener el objeto Product de la sesión usando el nombre como clave
        private Product GetProductFromSession(string name)
        {
            Dictionary<string, Product> products = Session["Products"] as Dictionary<string, Product>;
            if (products != null && products.ContainsKey(name))
            {
                return products[name];
            }
            return null;
        }

        // Función para actualizar el contador y mostrarlo en el TextView
        private void UpdateCounterAndDisplay()
        {
            int counter = Convert.ToInt32(hiddenFieldCounter.Value) + 1;
            hiddenFieldCounter.Value = counter.ToString();
            textViewCounter.Text = "Contador: " + counter.ToString();
        }

        // Evento cuando se selecciona un elemento del ListBox
        protected void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el item seleccionado del ListBox y su texto
            string selectedName = listBox.SelectedItem.Text;

            // Obtener el objeto Product de la sesión usando el nombre como clave
            Product selectedProduct = GetProductFromSession(selectedName);

            // Mostrar las propiedades del objeto Product en los TextView
            if (selectedProduct != null)
            {
                textViewName.Text = "Nombre: " + selectedProduct.Name;
                textViewManufacturer.Text = "Fabricante: " + selectedProduct.Manufacturer;
                textViewCost.Text = "Costo: " + selectedProduct.Cost.ToString();

                // Actualizar el contador y mostrarlo en el TextView
                UpdateCounterAndDisplay();
            }
            else
            {
                // Manejar el caso cuando no se encuentra el producto en la sesión
                textViewName.Text = "Producto no encontrado";
                textViewManufacturer.Text = "";
                textViewCost.Text = "";

                // Actualizar el contador y mostrarlo en el TextView
                UpdateCounterAndDisplay();
            }
        }

        // Función para abrir otra página y pasar las propiedades del producto seleccionado
        private void AbrirOtraPaginaConParametros(string productName)
        {
            Product selectedProduct = GetProductFromSession(productName);

            if (selectedProduct != null)
            {
                // Construir la URL con las tres propiedades como parámetros en la query string
                string url = "OtraPagina.aspx?Name=" + selectedProduct.Name +
                             "&Manufacturer=" + selectedProduct.Manufacturer +
                             "&Cost=" + selectedProduct.Cost;

                // Redirigir a la otra página con los parámetros en la query string
                Response.Redirect(url);
            }
            else
            {
                // Manejar el caso cuando no se encuentra el producto en la sesión
                // ...
            }
        }

        // Evento del botón que llama a la función para abrir la otra página con los parámetros
        protected void ButtonAbrirOtraPagina_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del producto seleccionado en el ListBox
            string selectedName = listBox.SelectedItem.Text;

            // Llamar a la función para abrir la otra página con los parámetros del producto seleccionado
            AbrirOtraPaginaConParametros(selectedName);
        }
    }
}