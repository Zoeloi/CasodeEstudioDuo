using BibliotecaDigital.Datos;
using BibliotecaDigital.Models;
using BibliotecaDigital.Services;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Libro> libros = DatosIniciales.ObtenerLibrosIniciales();



        string[] autores = libros
                            .Select(l => l.Autor)
                            .Distinct()
                            .OrderBy(a => a)
                            .ToArray();

        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== BIBLIOTECA DIGITAL ESTUDIANTIL =====");
            Console.WriteLine("1. Búsqueda lineal de libro por título");
            Console.WriteLine("2. Búsqueda binaria de autor");
            Console.WriteLine("3. Libro más reciente y más antiguo");
            Console.WriteLine("4. Búsqueda por coincidencias en descripción");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    BuscadorLineal.BuscarPorTitulo(libros);
                    break;
                case 2:
                    BuscadorBinario.BuscarAutor(autores);
                    break;
                case 3:
                    BuscadorFecha.MostrarRecienteYAntiguo(libros);
                    break;
                case 4:
                    BuscadorDescripcion.BuscarCoincidencias(libros);
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 0);
    }
}
