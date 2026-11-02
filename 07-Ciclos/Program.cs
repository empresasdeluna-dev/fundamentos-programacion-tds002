/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Pide un número del 1 al 12 validado con do-while,
 *              muestra su tabla de multiplicar con while y la suma
 *              de todos los resultados con un acumulador.
 */

using System;

namespace _07_Ciclos
{
    class Program
    {
        // Límites del número que puede escribir el usuario y de la tabla
        const int MINIMO = 1;
        const int MAXIMO = 12;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int numero;
            bool esValido;

            // do-while: se ejecuta al menos una vez y repite mientras el dato no sea válido
            do
            {
                Console.Write($"Escribe un número entre {MINIMO} y {MAXIMO}: ");
                esValido = int.TryParse(Console.ReadLine(), out numero)
                           && numero >= MINIMO && numero <= MAXIMO;

                if (!esValido)
                {
                    Console.WriteLine("Número inválido, intenta de nuevo.");
                }
            } while (!esValido);

            Console.WriteLine();
            Console.WriteLine($"======= TABLA DEL {numero} =======");

            int contador = 1;   // controla cuántas veces se repite el ciclo
            int sumaTotal = 0;  // acumulador de todos los resultados

            // while: repite mientras el contador no pase de 12
            while (contador <= MAXIMO)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero,2} x {contador,2} = {resultado,3}");

                sumaTotal += resultado;
                contador++;
            }

            Console.WriteLine("===========================");
            Console.WriteLine($"Suma de todos los resultados: {sumaTotal}");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
