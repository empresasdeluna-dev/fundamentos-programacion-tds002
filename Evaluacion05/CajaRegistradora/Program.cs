/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Caja registradora que lee precios hasta que se escriba 0
 *              y muestra la cantidad de productos, subtotal, ITBIS y total.
 */

using System;
using System.Globalization;

namespace CajaRegistradora
{
    class Program
    {
        // Impuesto sobre la venta en República Dominicana
        const decimal PORCENTAJE_ITBIS = 0.18m; // 18 %

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========= CAJA REGISTRADORA =========");
            Console.WriteLine("Escribe los precios uno por uno, 0 para terminar.");

            int cantidadProductos = 0; // contador de productos registrados
            decimal subtotal = 0;      // acumulador de los precios
            decimal precio;

            // do-while: pide al menos un precio y repite hasta que se escriba 0
            do
            {
                Console.Write($"Precio del producto {cantidadProductos + 1}: RD$ ");
                string textoPrecio = (Console.ReadLine() ?? "").Replace(',', '.');

                // TryParse evita que el programa se caiga si escriben letras
                bool esValido = decimal.TryParse(textoPrecio, NumberStyles.Number, CultureInfo.InvariantCulture, out precio);

                if (!esValido || precio < 0)
                {
                    Console.WriteLine("Precio inválido, escribe un número mayor que 0 (o 0 para terminar).");
                    precio = -1; // valor distinto de 0 para que el ciclo siga
                }
                else if (precio > 0)
                {
                    cantidadProductos++;
                    subtotal += precio;
                }
            } while (precio != 0);

            decimal montoItbis = subtotal * PORCENTAJE_ITBIS;
            decimal totalPagar = subtotal + montoItbis;

            Console.WriteLine();
            Console.WriteLine("============== RESUMEN ==============");
            Console.WriteLine($"Productos:      {cantidadProductos,15}");
            Console.WriteLine($"Subtotal:       RD$ {subtotal,11:N2}");
            Console.WriteLine($"ITBIS (18 %):   RD$ {montoItbis,11:N2}");
            Console.WriteLine($"TOTAL:          RD$ {totalPagar,11:N2}");
            Console.WriteLine("=====================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
