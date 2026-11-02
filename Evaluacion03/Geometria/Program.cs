/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Calcula el área y la circunferencia de un círculo
 *              y la hipotenusa de un triángulo rectángulo usando Math.
 */

using System;
using System.Globalization;

namespace Geometria
{
    class Program
    {
        // Exponente para elevar al cuadrado con Math.Pow
        const double CUADRADO = 2;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============= GEOMETRÍA =============");

            // ---------- ENTRADA ----------
            // Se cambia la coma por punto para aceptar 5.5 o 5,5
            Console.Write("Radio del círculo: ");
            string textoRadio = (Console.ReadLine() ?? "0").Replace(',', '.');
            double radio = double.Parse(textoRadio, CultureInfo.InvariantCulture);

            Console.Write("Cateto A del triángulo: ");
            string textoCatetoA = (Console.ReadLine() ?? "0").Replace(',', '.');
            double catetoA = double.Parse(textoCatetoA, CultureInfo.InvariantCulture);

            Console.Write("Cateto B del triángulo: ");
            string textoCatetoB = (Console.ReadLine() ?? "0").Replace(',', '.');
            double catetoB = double.Parse(textoCatetoB, CultureInfo.InvariantCulture);

            // ---------- PROCESO ----------
            // Área del círculo: π * r²
            double areaCirculo = Math.PI * Math.Pow(radio, CUADRADO);

            // Circunferencia (perímetro del círculo): 2 * π * r
            double circunferencia = 2 * Math.PI * radio;

            // Teorema de Pitágoras: hipotenusa = √(a² + b²)
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, CUADRADO) + Math.Pow(catetoB, CUADRADO));

            // ---------- SALIDA ----------
            Console.WriteLine();
            Console.WriteLine("============ RESULTADOS =============");
            Console.WriteLine("Círculo");
            Console.WriteLine($"  Radio:          {radio,10:F2}");
            Console.WriteLine($"  Área:           {areaCirculo,10:F2}");
            Console.WriteLine($"  Circunferencia: {circunferencia,10:F2}");
            Console.WriteLine("Triángulo rectángulo");
            Console.WriteLine($"  Cateto A:       {catetoA,10:F2}");
            Console.WriteLine($"  Cateto B:       {catetoB,10:F2}");
            Console.WriteLine($"  Hipotenusa:     {hipotenusa,10:F2}");
            Console.WriteLine("=====================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
