/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Convierte un monto en pesos dominicanos a dólares
 *              usando una constante con la tasa del día.
 */

using System;
using System.Globalization;

namespace ConversorMoneda
{
    class Program
    {
        // Tasa de venta del dólar según el Banco Central (29/10/2026)
        const double TASA_USD = 60.90;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // double: se cambia la coma por punto para aceptar 1500.50 o 1500,50
            Console.Write("Escribe el monto en pesos (RD$): ");
            string textoMonto = (Console.ReadLine() ?? "0").Replace(',', '.');
            double montoPesos = double.Parse(textoMonto, CultureInfo.InvariantCulture);

            // Para pasar de pesos a dólares se divide entre la tasa
            double montoDolares = montoPesos / TASA_USD;

            Console.WriteLine();
            Console.WriteLine("========= CONVERSOR DE MONEDA =========");
            Console.WriteLine($"Tasa del día:  RD$ {TASA_USD:F2} por US$ 1");
            Console.WriteLine($"Monto:         RD$ {montoPesos:F2}");
            Console.WriteLine($"Equivale a:    US$ {montoDolares:F2}");
            Console.WriteLine("=======================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
