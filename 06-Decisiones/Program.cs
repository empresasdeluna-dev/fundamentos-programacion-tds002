/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Estructuras de decisión.
 *              Parte 1: convierte una nota numérica en letra con if - else if - else.
 *              Parte 2: calculadora de cuatro operaciones con switch.
 */

using System;
using System.Globalization;

namespace _06_Decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // =============== PARTE 1: CALIFICACIÓN ===============
            Console.WriteLine("============ CALIFICACIÓN ============");
            Console.Write("Escribe la nota (0-100): ");

            // int.TryParse devuelve false si el texto no es un número entero,
            // así el programa no se cae si el usuario escribe letras
            bool esNumero = int.TryParse(Console.ReadLine(), out int nota);

            if (!esNumero || nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota inválida, debe ser un número entero entre 0 y 100.");
            }
            else
            {
                // Se evalúa de la nota más alta a la más baja
                string letra;
                if (nota >= 90)
                {
                    letra = "A";
                }
                else if (nota >= 80)
                {
                    letra = "B";
                }
                else if (nota >= 70)
                {
                    letra = "C";
                }
                else
                {
                    letra = "F";
                }

                Console.WriteLine($"Con {nota} puntos tu calificación es: {letra}");
            }

            // =============== PARTE 2: CALCULADORA ===============
            Console.WriteLine();
            Console.WriteLine("============ CALCULADORA =============");

            // Se cambia la coma por punto para aceptar 2.5 o 2,5
            Console.Write("Primer número: ");
            string textoPrimero = (Console.ReadLine() ?? "").Replace(',', '.');
            bool primeroValido = double.TryParse(textoPrimero, NumberStyles.Float, CultureInfo.InvariantCulture, out double primerNumero);

            Console.Write("Segundo número: ");
            string textoSegundo = (Console.ReadLine() ?? "").Replace(',', '.');
            bool segundoValido = double.TryParse(textoSegundo, NumberStyles.Float, CultureInfo.InvariantCulture, out double segundoNumero);

            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Elige una opción: ");
            int.TryParse(Console.ReadLine(), out int opcion);

            if (!primeroValido || !segundoValido)
            {
                Console.WriteLine("Alguno de los números no es válido.");
            }
            else
            {
                // switch elige el bloque según el valor de la opción
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"{primerNumero} + {segundoNumero} = {primerNumero + segundoNumero:F2}");
                        break;
                    case 2:
                        Console.WriteLine($"{primerNumero} - {segundoNumero} = {primerNumero - segundoNumero:F2}");
                        break;
                    case 3:
                        Console.WriteLine($"{primerNumero} * {segundoNumero} = {primerNumero * segundoNumero:F2}");
                        break;
                    case 4:
                        // Antes de dividir se verifica que el divisor no sea 0
                        if (segundoNumero == 0)
                        {
                            Console.WriteLine("No se puede dividir entre 0.");
                        }
                        else
                        {
                            Console.WriteLine($"{primerNumero} / {segundoNumero} = {primerNumero / segundoNumero:F2}");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción inválida, debe ser 1, 2, 3 o 4.");
                        break;
                }
            }

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
