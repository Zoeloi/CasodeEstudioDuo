using System;
using System.Linq;

namespace BibliotecaDigital.Services
{
    public static class BuscadorBinario
    {
        public static void BuscarAutor(string[] autores)
        {
            Console.Write("Ingrese el autor a buscar: ");
            string objetivo = Console.ReadLine();

            int inicio = 0;
            int fin = autores.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                int comparacion = string.Compare(objetivo, autores[medio], true);

                if (comparacion == 0)
                {
                    Console.WriteLine($" Autor encontrado: {autores[medio]}");
                    return;
                }

                if (comparacion < 0)
                    fin = medio - 1;
                else
                    inicio = medio + 1;
            }

            Console.WriteLine(" Autor no encontrado.");
        }
    }
}
