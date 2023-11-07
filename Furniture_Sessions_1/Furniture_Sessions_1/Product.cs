using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Furniture_Sessions_1
{
    public class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Cost { get; set; }

        // Constructor por defecto
        public Product()
        {
        }

        // Constructor con parámetros para inicializar las propiedades
        public Product(string name, string manufacturer, float cost)
        {
            Name = name;
            Manufacturer = manufacturer;
            Cost = cost;
        }
    }
}