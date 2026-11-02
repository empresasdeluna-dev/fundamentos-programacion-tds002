/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Pide nombre, edad, estatura y si la persona trabaja,
 *              muestra una ficha personal y el año en que cumplirá 30 años.
 */

using System;
using System.Globalization;

namespace FichaPersonal
{
    class Program
    {
        // Año actual y edad objetivo para el cálculo
        const int ANIO_ACTUAL = 2026;
        const int EDAD_OBJETIVO = 30;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // string: el nombre se guarda tal cual lo escribe el usuario
            Console.Write("Escribe tu nombre: ");
            string nombreCompleto = Console.ReadLine() ?? "";

            // int: la edad se convierte de texto a entero con int.Parse
            Console.Write("Escribe tu edad: ");
            int edadActual = int.Parse(Console.ReadLine() ?? "0");

            // double: se cambia la coma por punto para aceptar 1.75 o 1,75
            Console.Write("Escribe tu estatura en metros (ej. 1.75): ");
            string textoEstatura = (Console.ReadLine() ?? "0").Replace(',', '.');
            double estaturaMetros = double.Parse(textoEstatura, CultureInfo.InvariantCulture);

            // bool: Convert.ToBoolean solo acepta "true" o "false"
            Console.Write("¿Trabajas? (true/false): ");
            bool trabaja = Convert.ToBoolean((Console.ReadLine() ?? "false").Trim());

            // Año en que cumplirá 30: se suman los años que le faltan al año actual
            int aniosFaltantes = EDAD_OBJETIVO - edadActual;
            int anioCumple30 = ANIO_ACTUAL + aniosFaltantes;

            // Texto para mostrar el bool de forma más clara
            string textoTrabaja = trabaja ? "Sí" : "No";

            Console.WriteLine();
            Console.WriteLine("=========== FICHA PERSONAL ===========");
            Console.WriteLine($"Nombre:    {nombreCompleto}");
            Console.WriteLine($"Edad:      {edadActual} años");
            Console.WriteLine($"Estatura:  {estaturaMetros:F2} m");
            Console.WriteLine($"Trabaja:   {textoTrabaja}");
            Console.WriteLine("======================================");

            // Mensaje según si ya cumplió los 30 o todavía no
            if (aniosFaltantes > 0)
            {
                Console.WriteLine($"Cumplirás 30 años en el {anioCumple30}, te faltan {aniosFaltantes}.");
            }
            else
            {
                Console.WriteLine($"Cumpliste 30 años en el {anioCumple30}.");
            }

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
