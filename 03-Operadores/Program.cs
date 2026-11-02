/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Lee dos números enteros y muestra las operaciones
 *              aritméticas básicas y si el primero es par.
 */

using System;

namespace _03_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Lectura de los dos enteros
            Console.Write("Escribe el primer número entero (x): ");
            int x = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Escribe el segundo número entero (y): ");
            int y = int.Parse(Console.ReadLine() ?? "0");

            // Operadores aritméticos con enteros
            int suma = x + y;
            int resta = x - y;
            int producto = x * y;

            // Un número es par si al dividirlo entre 2 el residuo es 0
            bool esPar = x % 2 == 0;

            Console.WriteLine();
            Console.WriteLine("============ OPERADORES ============");
            Console.WriteLine($"Suma:            {x} + {y} = {suma}");
            Console.WriteLine($"Resta:           {x} - {y} = {resta}");
            Console.WriteLine($"Producto:        {x} * {y} = {producto}");

            // No se puede dividir entre 0, así que se verifica antes
            if (y != 0)
            {
                // División real: se convierte x a double para no perder los decimales
                double divisionReal = (double)x / y;

                // División entera: entre dos int, C# descarta la parte decimal
                int divisionEntera = x / y;

                // Residuo: lo que sobra de la división entera
                int residuo = x % y;

                Console.WriteLine($"División real:   {x} / {y} = {divisionReal:F2}");
                Console.WriteLine($"División entera: {x} / {y} = {divisionEntera}");
                Console.WriteLine($"Residuo:         {x} % {y} = {residuo}");
            }
            else
            {
                Console.WriteLine("División y residuo: no se puede dividir entre 0");
            }

            Console.WriteLine($"¿{x} es par?:     {esPar}");
            Console.WriteLine("====================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}

/*
 * PRUEBA DE ESCRITORIO (x = 10, y = 3)
 *
 * | Paso | Instrucción                      | x  | y | Resultado       |
 * |------|----------------------------------|----|---|-----------------|
 * | 1    | int x = 10                       | 10 | - | x = 10          |
 * | 2    | int y = 3                        | 10 | 3 | y = 3           |
 * | 3    | suma = x + y                     | 10 | 3 | 13              |
 * | 4    | resta = x - y                    | 10 | 3 | 7               |
 * | 5    | producto = x * y                 | 10 | 3 | 30              |
 * | 6    | esPar = x % 2 == 0               | 10 | 3 | 10 % 2 = 0, true|
 * | 7    | y != 0                           | 10 | 3 | true, entra     |
 * | 8    | divisionReal = (double)x / y     | 10 | 3 | 3.33            |
 * | 9    | divisionEntera = x / y           | 10 | 3 | 3               |
 * | 10   | residuo = x % y                  | 10 | 3 | 1               |
 *
 * Salida esperada:
 *   Suma:            10 + 3 = 13
 *   Resta:           10 - 3 = 7
 *   Producto:        10 * 3 = 30
 *   División real:   10 / 3 = 3.33
 *   División entera: 10 / 3 = 3
 *   Residuo:         10 % 3 = 1
 *   ¿10 es par?:     True
 *
 * Observación: 10 / 3 da 3 y no 3.33 porque los dos son int,
 * para obtener los decimales hay que convertir uno a double.
 */
