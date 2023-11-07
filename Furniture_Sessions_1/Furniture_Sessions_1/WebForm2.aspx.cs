using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Furniture_Sessions_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verificar si hay parámetros en el query string
                if (Request.QueryString["Name"] == null || Request.QueryString["Manufacturer"] == null || Request.QueryString["Cost"] == null)
                {
                    // Si no hay parámetros en el query string, obtener los datos de la sesión
                    Product selectedProduct = Session["SelectedProduct"] as Product;

                    if (selectedProduct != null)
                    {
                        // Mostrar los datos del producto en los TextViews o realizar otras acciones necesarias
                        textViewName.Text = "Nombre: " + selectedProduct.Name;
                        textViewManufacturer.Text = "Fabricante: " + selectedProduct.Manufacturer;
                        textViewCost.Text = "Costo: " + selectedProduct.Cost.ToString();
                    }
                    else
                    {
                        // Manejar el caso cuando no hay datos del producto en la sesión
                        // ...
                    }
                }
                else
                {
                    // Si hay parámetros en el query string, mostrar los datos del query string en los TextViews
                    string name = Request.QueryString["Name"];
                    string manufacturer = Request.QueryString["Manufacturer"];
                    float cost = Convert.ToSingle(Request.QueryString["Cost"]);

                    textViewName.Text = "Nombre: " + name;
                    textViewManufacturer.Text = "Fabricante: " + manufacturer;
                    textViewCost.Text = "Costo: " + cost.ToString();
                }
            }
        }
    }
}