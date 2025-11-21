using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDigital.Models;

namespace BibliotecaDigital.Datos
{
    public static class DatosIniciales
    {
        public static List<Libro> ObtenerLibrosIniciales()
        {
            return new List<Libro>
            {
                new Libro
                {
                    Titulo = "Cien Años de Soledad",
                    Autor = "Gabriel García Márquez",
                    Año = 1967,
                    Descripcion = "Una novela que narra la historia de la familia Buendía a lo largo de siete generaciones en el pueblo ficticio de Macondo."
                },
                new Libro
                {
                    Titulo = "Don Quijote de la Mancha",
                    Autor = "Miguel de Cervantes",
                    Año = 1605,
                    Descripcion = "La historia de un hidalgo que, influenciado por los libros de caballerías, decide convertirse en caballero andante."
                },
                new Libro
                {
                    Titulo = "La Sombra del Viento",
                    Autor = "Carlos Ruiz Zafón",
                    Año = 2001,
                    Descripcion = "Un joven llamado Daniel descubre un libro olvidado que cambiará su vida y lo llevará a desentrañar un misterio literario."
                },
                new Libro
                {
                    Titulo="Programación en C#", 
                    Autor="Juan Pérez", 
                    Año=2020,
                    Descripcion="Guía básica para aprender C# desde cero."},

                new Libro
                {
                    Titulo="Algoritmos y Estructuras", 
                    Autor="Ana Gómez", Año=2015,
                    Descripcion="Explicación de algoritmos de búsqueda."},

                new Libro
                {
                    Titulo="Historia de la Computación", 
                    Autor="Carlos Ruiz", 
                    Año=2005,
                    Descripcion="Evolución de la computación moderna."},

                new Libro
                {
                    Titulo="Inteligencia Artificial", 
                    Autor="Luis Torres", 
                    Año=2022,
                    Descripcion="Fundamentos y aplicaciones de la IA."},

                new Libro
                {
                    Titulo="Bases de Datos Modernas", 
                    Autor="María López", 
                    Año=2018,
                    Descripcion="Introducción a modelos de datos, SQL, NoSQL y diseño de bases de datos."},

                new Libro
                {
                 Titulo="Redes de Computadoras", 
                 Autor="Roberto Martínez", 
                 Año=2012,
                 Descripcion="Fundamentos de redes, protocolos, topologías y seguridad en comunicaciones."},

                new Libro
                {
                    Titulo="Desarrollo Web Full Stack", 
                    Autor="Sofía Andrade", 
                    Año=2021,
                    Descripcion="Guía completa sobre HTML, CSS, JavaScript, APIs y frameworks modernos."},

                new Libro
                {
                    Titulo="Sistemas Operativos", 
                    Autor="Gabriel Castillo", 
                    Año=2009,
                    Descripcion="Principios de administración de procesos, memoria, archivos y concurrencia."}


            };
        }

    }
}
