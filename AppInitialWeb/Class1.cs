using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppInitialWeb
{
    public class Class1
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Cost { get; set; }

        // Constructor por defecto
        public Class1()
        {
        }

        // Constructor con parámetros para inicializar las propiedades
        public Class1(string name, string manufacturer, float cost)
        {
            Name = name;
            Manufacturer = manufacturer;
            Cost = cost;
        }
    }
}