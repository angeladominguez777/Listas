using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    //Ángela Domínguez Maldonado
    internal class Acciones
    {
        public List<Autos> listaautomoviles = new List<Autos>();
        Autos a = new Autos();

        public void AgregarAuto()
        {
            Console.WriteLine("Marca:");
            a.Marca = Console.ReadLine();

            Console.WriteLine("Modelo:");
            a.Modelo = Console.ReadLine();

            Console.WriteLine("Anio:");
            a.Anio = Console.ReadLine();

            Console.WriteLine("Número de puertas:");
            a.NumPuertas = Console.ReadLine();

            Console.WriteLine("Color:");
            a.Color = Console.ReadLine();

            listaautomoviles.Add(new Autos(a.Marca, a.Modelo, a.Anio, a.NumPuertas, a.Color));
        }

        public void MostrarAutos()
        {
            foreach (var a in  listaautomoviles)
            {
                Console.WriteLine(a.Marca);
                Console.WriteLine(a.Modelo);
                Console.WriteLine(a.Anio);
                Console.WriteLine(a.NumPuertas);
                Console.WriteLine(a.Color);
            }
        }

        public int ContarAutomoviles()
        {
            return listaautomoviles.Count;
        }

        public void EliminarAutomovil(string nombremarca)
        {
            var automovil = listaautomoviles.Find(x => x.Marca == nombremarca);
            if (automovil != null)
                listaautomoviles.Remove(automovil);

            else
                Console.WriteLine("No se encuentra tu automóvil");
        }

        public void ActualizarAutomovilPorMarca()
        {
            // Pedir al usuario la marca del automóvil a actualizar
            Console.WriteLine("Ingrese la marca del automóvil que desea actualizar:");
            string marcaantigua = Console.ReadLine();

            // Buscar el automóvil por la marca
            var automovil = listaautomoviles.Find(x => x.Marca == marcaantigua);

            if (automovil != null)
            {
                // Solicitar los nuevos datos al usuario
                Console.WriteLine("Automóvil encontrado. Ingrese los nuevos datos.");

                Console.WriteLine("Ingrese la nueva marca:");
                string nuevaMarca = Console.ReadLine();

                Console.WriteLine("Ingrese el nuevo modelo:");
                string nuevoModelo = Console.ReadLine();

                Console.WriteLine("Ingrese nuevo año:");
                int nuevoAnio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nuevo número de puertas");
                int nuenonumpuertas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese nuevo color");
                string nuevocolor = Console.ReadLine();


                // Actualizar las propiedades del automóvil
                automovil.Marca = nuevaMarca;
                automovil.Modelo = nuevoModelo;

                automovil.Anio = nuevoAnio;
                automovil.NumPuertas = nuenonumpuertas;
                automovil.Color = nuevocolor;

                Console.WriteLine("Automóvil actualizado con éxito.");
            }
            else
            {
                //Este es un comentario nievo
                Console.WriteLine("No se encuentra el automóvil con la marca especificada.");
            }
        }

    }
}
