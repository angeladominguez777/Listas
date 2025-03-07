using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
    //Ángela Domínguez Maldonado
{
    internal class Autos
    {
        public Autos() { }
        public Autos(string marca, string modelo, string anio, string numPuertas, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            NumPuertas = numPuertas;
            Color = color;
        }

        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public string NumPuertas { get; set; }
        public string Color { get; set; }
    }
}
