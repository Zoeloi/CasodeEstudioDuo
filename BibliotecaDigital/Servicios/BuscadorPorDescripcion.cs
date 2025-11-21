using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaDigital.Models;

namespace BibliotecaDigital.Services
{
    public static class BuscadorDescripcion
    {
        public static void BuscarCoincidencias(List<Libro> libros)
        {
            Console.Write("Ingrese una palabra clave: ");
            string clave = Console.ReadLine().ToLower();

            var resultados = libros
                .Where(l => l.Descripcion.ToLower().Contains(clave))
                .ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("✗ No se encontraron coincidencias.");
                return;
            }

            Console.WriteLine("\nResultados:");
            foreach (var l in resultados)
                Console.WriteLine($"• {l.Titulo} - {l.Descripcion}");
        }
    }
}
