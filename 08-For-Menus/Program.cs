/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Menú con do-while y switch que muestra las tablas
 *              del 1 al 10 con ciclos for anidados o dibuja un
 *              triángulo de asteriscos de N filas.
 */

using System;

namespace _08_For_Menus
{
    class Program
    {
        // Hasta qué número llegan las tablas
        const int LIMITE_TABLAS = 10;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int opcion;

            // do-while: el menú aparece al menos una vez y se repite hasta elegir 0
            do
            {
                Console.WriteLine();
                Console.WriteLine("=========== MENÚ ===========");
                Console.WriteLine("1. Tablas de multiplicar");
                Console.WriteLine("2. Triángulo de asteriscos");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                // Si no es un número se usa -1 para que caiga en default
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();

                        // Encabezado con los números de columna
                        Console.Write("   x");
                        for (int columna = 1; columna <= LIMITE_TABLAS; columna++)
                        {
                            Console.Write($"{columna,4}");
                        }
                        Console.WriteLine();
                        Console.WriteLine(new string('-', 4 * (LIMITE_TABLAS + 1)));

                        // Ciclo externo: recorre las filas (tabla del 1, del 2...)
                        for (int fila = 1; fila <= LIMITE_TABLAS; fila++)
                        {
                            Console.Write($"{fila,4}");

                            // Ciclo interno: recorre las columnas de cada fila
                            for (int columna = 1; columna <= LIMITE_TABLAS; columna++)
                            {
                                Console.Write($"{fila * columna,4}");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.Write("¿Cuántas filas tendrá el triángulo?: ");
                        if (!int.TryParse(Console.ReadLine(), out int cantidadFilas) || cantidadFilas < 1)
                        {
                            Console.WriteLine("Debe ser un número entero mayor que 0.");
                            break;
                        }

                        Console.WriteLine();

                        // Ciclo externo: una vuelta por cada fila
                        for (int fila = 1; fila <= cantidadFilas; fila++)
                        {
                            // Ciclo interno: la fila 1 lleva 1 asterisco, la fila 2 lleva 2, etc.
                            for (int asterisco = 1; asterisco <= fila; asterisco++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, elige 1, 2 o 0.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
