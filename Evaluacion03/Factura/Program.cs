/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Genera una factura de un producto con subtotal,
 *              ITBIS y total, mostrada en columnas alineadas.
 */

using System;
using System.Globalization;

namespace Factura
{
    class Program
    {
        // Impuesto sobre la venta en República Dominicana
        const decimal PORCENTAJE_ITBIS = 0.18m; // 18 %

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============== FACTURA ==============");

            // ---------- ENTRADA ----------
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine() ?? "";

            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine() ?? "0");

            // decimal es el tipo recomendado para dinero, la coma se cambia por punto
            Console.Write("Precio unitario (RD$): ");
            string textoPrecio = (Console.ReadLine() ?? "0").Replace(',', '.');
            decimal precioUnitario = decimal.Parse(textoPrecio, CultureInfo.InvariantCulture);

            // ---------- PROCESO ----------
            // int * decimal: la cantidad se convierte sola a decimal
            decimal subtotal = cantidad * precioUnitario;
            decimal montoItbis = subtotal * PORCENTAJE_ITBIS;
            decimal totalPagar = subtotal + montoItbis;

            // ---------- SALIDA ----------
            // PadRight rellena a la derecha para alinear el texto a la izquierda,
            // {valor,12:N2} reserva 12 espacios y alinea el número a la derecha
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine($"{"Producto".PadRight(18)}{"Cant.",5}{"Precio",11}{"Importe",11}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"{nombreProducto.PadRight(18)}{cantidad,5}{precioUnitario,11:N2}{subtotal,11:N2}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"{"Subtotal:".PadRight(30)}RD${subtotal,12:N2}");
            Console.WriteLine($"{"ITBIS (18 %):".PadRight(30)}RD${montoItbis,12:N2}");
            Console.WriteLine($"{"TOTAL A PAGAR:".PadRight(30)}RD${totalPagar,12:N2}");
            Console.WriteLine("=============================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
