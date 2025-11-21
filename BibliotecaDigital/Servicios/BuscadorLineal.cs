using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaDigital.Models;

namespace BibliotecaDigital.Services
{
    public static class BuscadorLineal
    {
        public static void BuscarPorTitulo(List<Libro> libros)
        {
            Console.Write("Ingrese el título a buscar: ");
            string titulo = Console.ReadLine().ToLower();

            var libro = libros.FirstOrDefault(l => l.Titulo.ToLower().Contains(titulo));

            if (libro == null)
                Console.WriteLine("✗ No se encontró el libro.");
            else
                Console.WriteLine($"✓ Encontrado: {libro.Titulo} ({libro.Año}) - {libro.Autor}");
        }
    }
}