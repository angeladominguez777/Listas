using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
    //Ángela Domínguez Maldonado
{
    internal class Program
    {
        public enum Menu
        {
            AgregarAuto = 1, MostrarAutos, ContarAutomoviles, EliminarAutomovil, ActualizarAutomovilPorMarca
        }

        static void Main(string[] args)
        {
            Acciones auto = new Acciones();
            while (true)
            {
                switch(menu())
                {
                    case Menu.AgregarAuto:
                        Console.WriteLine("Agregar auto");
                        auto.AgregarAuto();
                        break;
                    case Menu.MostrarAutos:
                        Console.WriteLine("Mostrar auto");
                        auto.MostrarAutos();
                        break;
                    case Menu.ContarAutomoviles:
                        Console.WriteLine("Contar autos:");
                        auto.ContarAutomoviles();
                        break;
                    case Menu.EliminarAutomovil:
                        Console.WriteLine("Eliminar auto:");
                        string nombremarca = Console.ReadLine();
                        auto.EliminarAutomovil(nombremarca);
                        break;
                    case Menu.ActualizarAutomovilPorMarca:
                        Console.WriteLine("Actualizar auto:");
                        auto.ActualizarAutomovilPorMarca();
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("Agregar");
            Console.WriteLine("Mostrar");
            Console.WriteLine("Contar");
            Console.WriteLine("Eliminar");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
