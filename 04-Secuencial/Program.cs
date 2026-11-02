/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Conversor de unidades con estructura secuencial
 *              (entrada, proceso y salida). Convierte un peso de libras
 *              a kilogramos y una temperatura de °F a °C.
 */

using System;
using System.Globalization;

namespace _04_Secuencial
{
    class Program
    {
        // Equivalencia fija: 1 libra = 0.453592 kilogramos
        const double KG_POR_LIBRA = 0.453592;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y el símbolo ° se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("======= CONVERSOR DE UNIDADES =======");

            // ---------- ENTRADA ----------
            // Se cambia la coma por punto para aceptar 150.5 o 150,5
            Console.Write("Escribe el peso en libras (lb): ");
            string textoLibras = (Console.ReadLine() ?? "0").Replace(',', '.');
            double pesoLibras = double.Parse(textoLibras, CultureInfo.InvariantCulture);

            Console.Write("Escribe la temperatura en grados Fahrenheit (°F): ");
            string textoFahrenheit = (Console.ReadLine() ?? "0").Replace(',', '.');
            double temperaturaFahrenheit = double.Parse(textoFahrenheit, CultureInfo.InvariantCulture);

            // ---------- PROCESO ----------
            // Libras a kilogramos: se multiplica por la constante
            double pesoKilogramos = pesoLibras * KG_POR_LIBRA;

            // Fahrenheit a Celsius: (F - 32) * 5 / 9
            // Se usa 5.0 y 9.0 para que la división sea real y no entera
            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5.0 / 9.0;

            // ---------- SALIDA ----------
            Console.WriteLine();
            Console.WriteLine("============ RESULTADOS =============");
            Console.WriteLine($"Peso:        {pesoLibras:F2} lb equivalen a {pesoKilogramos:F2} kg");
            Console.WriteLine($"Temperatura: {temperaturaFahrenheit:F2} °F equivalen a {temperaturaCelsius:F2} °C");
            Console.WriteLine("=====================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
