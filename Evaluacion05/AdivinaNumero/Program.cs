/*
 * Nombre: Cristian Alberto De Luna Santana
 * Fecha: 02/11/2026
 * Descripción: Juego de adivinar un número secreto del 1 al 100,
 *              con pistas de mayor o menor y conteo de intentos.
 */

using System;

namespace AdivinaNumero
{
    class Program
    {
        // Rango del número secreto
        const int MINIMO = 1;
        const int MAXIMO = 100;

        static void Main(string[] args)
        {
            // Habilita UTF-8 para que las tildes y la ñ se vean bien en la consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Next(1, 101) genera de 1 a 100, el segundo valor no se incluye
            int numeroSecreto = Random.Shared.Next(MINIMO, MAXIMO + 1);

            int intentos = 0; // contador de intentos válidos
            int numeroUsuario;

            Console.WriteLine("========= ADIVINA EL NÚMERO =========");
            Console.WriteLine($"Pensé un número del {MINIMO} al {MAXIMO}, ¿cuál es?");

            // do-while: el usuario intenta al menos una vez y sigue hasta acertar
            do
            {
                Console.Write("Tu intento: ");
                bool esValido = int.TryParse(Console.ReadLine(), out numeroUsuario);

                if (!esValido || numeroUsuario < MINIMO || numeroUsuario > MAXIMO)
                {
                    // Un dato inválido no cuenta como intento
                    Console.WriteLine($"Escribe un número entero del {MINIMO} al {MAXIMO}.");
                    numeroUsuario = -1;
                    continue;
                }

                intentos++;

                if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("Es mayor.");
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine("Es menor.");
                }
            } while (numeroUsuario != numeroSecreto);

            Console.WriteLine();
            Console.WriteLine($"¡Correcto! El número era {numeroSecreto}.");
            Console.WriteLine($"Lo adivinaste en {intentos} intento(s).");

            // Pausa para que la ventana no se cierre de golpe al ejecutar
            Console.ReadKey();
        }
    }
}
