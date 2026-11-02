/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Lee notas válidas (0-100) hasta que se escriba -1
 *              y muestra el promedio, la nota mayor y la menor.
 */

using System;
using System.Globalization;

namespace PromedioValidado
{
    class Program
    {
        // Rango permitido y valor que termina la captura
        const double NOTA_MINIMA = 0;
        const double NOTA_MAXIMA = 100;
        const double VALOR_SALIDA = -1;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("========= PROMEDIO DE NOTAS =========");
            Console.WriteLine("Escribe las notas una por una, -1 para terminar.");

            int cantidadNotas = 0;               // contador de notas válidas
            double sumaNotas = 0;                // acumulador
            double notaMayor = NOTA_MINIMA;      // se reemplaza con la primera nota
            double notaMenor = NOTA_MAXIMA;      // se reemplaza con la primera nota
            double nota;

            do
            {
                bool esValida;

                // do-while interno: repite la misma pregunta hasta que la nota sea válida
                do
                {
                    Console.Write($"Nota {cantidadNotas + 1}: ");
                    string textoNota = (Console.ReadLine() ?? "").Replace(',', '.');

                    esValida = double.TryParse(textoNota, NumberStyles.Float, CultureInfo.InvariantCulture, out nota)
                               && (nota == VALOR_SALIDA || (nota >= NOTA_MINIMA && nota <= NOTA_MAXIMA));

                    if (!esValida)
                    {
                        Console.WriteLine("Nota inválida, debe estar entre 0 y 100 (o -1 para terminar).");
                    }
                } while (!esValida);

                // Solo se cuentan las notas reales, no el -1
                if (nota != VALOR_SALIDA)
                {
                    cantidadNotas++;
                    sumaNotas += nota;

                    if (nota > notaMayor || cantidadNotas == 1)
                    {
                        notaMayor = nota;
                    }
                    if (nota < notaMenor || cantidadNotas == 1)
                    {
                        notaMenor = nota;
                    }
                }
            } while (nota != VALOR_SALIDA);

            Console.WriteLine();
            Console.WriteLine("============= RESULTADOS ============");

            // Si no se escribió ninguna nota no se puede dividir entre 0
            if (cantidadNotas == 0)
            {
                Console.WriteLine("No se registró ninguna nota.");
            }
            else
            {
                double promedio = sumaNotas / cantidadNotas;
                Console.WriteLine($"Notas registradas: {cantidadNotas,8}");
                Console.WriteLine($"Promedio:          {promedio,8:F2}");
                Console.WriteLine($"Nota mayor:        {notaMayor,8:F2}");
                Console.WriteLine($"Nota menor:        {notaMenor,8:F2}");
            }
            Console.WriteLine("=====================================");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
