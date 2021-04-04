using System;

namespace MacorattiCSharp.Aulas
{
    class Aula06
    {
        internal static void Exercicio01()
        {
            // goto – origem dos comandos de repetição (herança do código espagueti) não recomendado:
            int a = 0;
        repetir:
            Console.WriteLine($"a = {a}");
            a++;
            if (a < 10)
            {
                goto repetir;
            }
            Console.Write("\n");

            // while:
            int b = 0;
            while (b < 10)
            {
                Console.WriteLine($"b = {b}");
                b++;
            }
            Console.Write("\n");

            // do while:
            int c = 10;
            do
            {
                Console.WriteLine($"c = {c}");
                c--;
            } while (c > 0);
            Console.Write("\n");

            // for:
            for (int d = 0; d < 50; d++)
            {
                if (d % 10 == 0)
                {
                    Console.WriteLine($"\n{d}");
                }
                else
                {
                    Console.Write($"{d}\t");
                }
            }
            Console.WriteLine("\n");

            // foreach
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in numeros)
            {
                Console.WriteLine($"{item}");
            }
            Console.Write("\n");

            // continue-break
            while (true)
            {
                Console.Write("Digite um valor (5 para sair): ");
                int.TryParse(Console.ReadLine(), out int e);

                if (e % 3 == 0)
                {
                    Console.WriteLine("\nDivisível por 3.");
                    continue;
                }
                if (e % 5 == 0)
                {
                    Console.WriteLine("\nDivisível por 5.");
                    break;
                }
                Console.WriteLine("\nNão é divisível por 3, nem por 5.");
            }
        }
    }
}