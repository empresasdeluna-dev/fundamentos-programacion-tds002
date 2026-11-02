/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Calcula la nómina de un empleado (salario bruto,
 *              descuentos de AFP y SFS, y salario neto).
 */

using System;
using System.Globalization;

namespace Nomina
{
    class Program
    {
        // Porcentajes de descuento que paga el empleado
        const decimal PORCENTAJE_AFP = 0.0287m; // 2.87 %
        const decimal PORCENTAJE_SFS = 0.0304m; // 3.04 %

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============== NÓMINA ==============");

            // ---------- ENTRADA ----------
            Console.Write("Nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine() ?? "";

            // decimal es el tipo recomendado para dinero, la coma se cambia por punto
            Console.Write("Horas trabajadas: ");
            string textoHoras = (Console.ReadLine() ?? "0").Replace(',', '.');
            decimal horasTrabajadas = decimal.Parse(textoHoras, CultureInfo.InvariantCulture);

            Console.Write("Pago por hora (RD$): ");
            string textoPago = (Console.ReadLine() ?? "0").Replace(',', '.');
            decimal pagoPorHora = decimal.Parse(textoPago, CultureInfo.InvariantCulture);

            // ---------- PROCESO ----------
            decimal salarioBruto = horasTrabajadas * pagoPorHora;
            decimal descuentoAfp = salarioBruto * PORCENTAJE_AFP;
            decimal descuentoSfs = salarioBruto * PORCENTAJE_SFS;
            decimal salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

            // ---------- SALIDA ----------
            Console.WriteLine();
            Console.WriteLine("========== RECIBO DE PAGO ==========");
            Console.WriteLine($"Empleado:          {nombreEmpleado.ToUpper()}");
            Console.WriteLine($"Horas trabajadas:  {horasTrabajadas:N2}");
            Console.WriteLine($"Pago por hora:     RD$ {pagoPorHora,12:N2}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Salario bruto:     RD$ {salarioBruto,12:N2}");
            Console.WriteLine($"AFP (2.87 %):    - RD$ {descuentoAfp,12:N2}");
            Console.WriteLine($"SFS (3.04 %):    - RD$ {descuentoSfs,12:N2}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Salario neto:      RD$ {salarioNeto,12:N2}");
            Console.WriteLine("====================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
