/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Programa de consola que pide nombre, edad y estatura,
 *              calcula el año de nacimiento con una constante y muestra
 *              todo usando interpolación de cadenas.
 */

using System;
using System.Globalization;

namespace _02_Variables
{
    class Program
    {
        // Constante con el año actual, no cambia durante la ejecución
        const int ANIO_ACTUAL = 2026;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // string: guarda texto
            Console.Write("Escribe tu nombre: ");
            string nombre = Console.ReadLine() ?? "";

            // int: guarda números enteros
            Console.Write("Escribe tu edad: ");
            int edad = int.Parse(Console.ReadLine() ?? "0");

            // double: guarda números con decimales (acepta 1.75 o 1,75)
            Console.Write("Escribe tu estatura en metros (ej. 1.75): ");
            string entradaEstatura = (Console.ReadLine() ?? "0").Replace(',', '.');
            double estatura = double.Parse(entradaEstatura, CultureInfo.InvariantCulture);

            // Cálculo del año de nacimiento usando la constante
            int anioNacimiento = ANIO_ACTUAL - edad;

            // Salida con interpolación $"..."
            Console.WriteLine();
            Console.WriteLine("========== DATOS ==========");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Estatura: {estatura:F2} m");
            Console.WriteLine($"Año de nacimiento: {anioNacimiento}");
            Console.WriteLine("===========================");
            Console.WriteLine($"Hola {nombre}, naciste en {anioNacimiento} y mides {estatura:F2} m.");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
