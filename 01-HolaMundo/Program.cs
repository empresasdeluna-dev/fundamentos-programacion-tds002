/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 14/09/2026
 * Descripción: Programa de consola que imprime una tarjeta de presentación
 *              dentro de un marco construido con caracteres.
 */

using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Borde superior del marco
            Console.WriteLine("*==========================================*");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|                HOLA MUNDO                |");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|   Nombre: Cristian De Luna Santana       |");
            Console.WriteLine("|   Matrícula: 20260704                    |");
            Console.WriteLine("|   Carrera: Tecnología en Ciberseguridad  |");
            Console.WriteLine("|   Siempre aprendiendo algo nuevo         |");
            Console.WriteLine("|                                          |");

            // Borde inferior del marco
            Console.WriteLine("*==========================================*");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}