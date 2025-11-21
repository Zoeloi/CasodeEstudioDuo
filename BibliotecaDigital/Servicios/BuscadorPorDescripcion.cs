using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaDigital.Models;

namespace BibliotecaDigital.Services
{
    public static class BuscadorFecha
    {
        public static void MostrarRecienteYAntiguo(List<Libro> libros)
        {
            var reciente = libros.OrderByDescending(l => l.Año).First();
            var antiguo = libros.OrderBy(l => l.Año).First();

            Console.WriteLine($"📘 Más reciente: {reciente.Titulo} ({reciente.Año})");
            Console.WriteLine($"📕 Más antiguo: {antiguo.Titulo} ({antiguo.Año})");
        }
    }
}