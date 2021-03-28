using System;

namespace MacorattiCSharp.Aulas
{
    class Aula05
    {
        internal static void Exercicio01()
        {
            bool valor = true;
            // Indiretamente: valor == true
            if (valor)
            {
                Console.WriteLine($"Valor é {valor}");
            }

            int a, b, c;

            /*
             * Também é possivel atribuir a todos o mesmo valor(NA CRIAÇÃO).
             * int a, b, c = 5;
             *
             * Após não é possivel:
             * a, b, c = 5;
             */

            // Somente uma a uma:
            a = 2;
            b = 2;
            c = 4;

            // Ao não abrir e fechar chaves{} o C# entende SOMENTE a primeira linha após o if, por ememplo:
            /*
             * if (a < b)
             * Console.WriteLine($"{a} é < {b}");
             * Qualquer comando abaixo será executado independente do if.
             */
            if (a < b)
            {
                Console.WriteLine("a < b");
                Console.WriteLine($"O valor de a = {a}\nO valor de b = {b}");
            }
            else if (a > b)
            {
                Console.WriteLine("a > b");
                Console.WriteLine($"O valor de a = {a}\nO valor de b = {b}");
            }
            else
            {
                Console.WriteLine($"{a} == {b}");
                Console.WriteLine($"O valor de a = {a}\nO valor de b = {b}");
            }
            Console.WriteLine($"o valor de c = {c}");

            Console.WriteLine("informe um nº entre 0 - 10");
            int numero = 0;
            int.TryParse(Console.ReadLine(), out numero);
            if (numero > 10)
            {
                Console.WriteLine("o nº deve estar entre 0 - 10!");
            }
            else
            {
                if (numero < 0)
                {
                    Console.WriteLine("O nº deve ser maior que 0!");
                }
                else
                {
                    Console.WriteLine($"O nº digitado foi {numero}");
                }
            }
        }
    }
}