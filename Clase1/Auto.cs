using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Auto
    {
        private string Color { get; set; }
        private int NumeroDePuertas { get; set; }
        private string Marca { get; set; }

        public Auto(string Color, int NumeroDePuertas , string Marca)
        {
            this.Marca = Marca;
            this.NumeroDePuertas = NumeroDePuertas;
            this.Color = Color;
        }
        public string GetColor()
        {
            return this.Color;
        }
    }
}
