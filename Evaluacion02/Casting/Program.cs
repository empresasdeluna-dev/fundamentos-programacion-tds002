/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Demuestra el casting explícito de double a int
 *              y el casting implícito de int a double.
 */

using System;
using System.Globalization;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // double: se cambia la coma por punto para aceptar 7.85 o 7,85
            Console.Write("Escribe un número con decimales (ej. 7.85): ");
            string textoNumero = (Console.ReadLine() ?? "0").Replace(',', '.');
            double numeroDecimal = double.Parse(textoNumero, CultureInfo.InvariantCulture);

            // Casting explícito: se escribe (int) porque se pierde la parte decimal,
            // el valor se trunca, no se redondea (7.85 queda en 7)
            int parteEntera = (int)numeroDecimal;

            // Casting implícito: un int cabe completo en un double,
            // así que C# lo convierte solo, sin escribir nada
            int numeroEntero = parteEntera;
            double numeroConvertido = numeroEntero;

            Console.WriteLine();
            Console.WriteLine("============== CASTING ==============");
            Console.WriteLine($"Número original (double):      {numeroDecimal}");
            Console.WriteLine($"Explícito (int) double -> int: {parteEntera}");
            Console.WriteLine($"Implícito int -> double:       {numeroConvertido:F1}");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Al pasar a int se perdió: {numeroDecimal - parteEntera:F2}");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
