using System;

namespace MacorattiCSharp.Aulas
{
    class Aula05
    {
        internal static void Exercicio()
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

            int numero0 = 10;
            switch (numero0)
            {
                case 0:
                    Console.WriteLine("O nº digitado foi Zero");
                    break;
                case 1:
                    Console.WriteLine("O nº digitado foi Um");
                    break;
                default:
                    Console.WriteLine("O nº não corresponde a um 'CASE'");
                    break;
            }
            string carro = null;
            string fabrica = null;

            Console.Write("Digite a marca do seu carro: ");
            carro = Console.ReadLine();

            switch (carro.ToLower())
            {
                case "civic":
                case "fit":
                case "city":
                    fabrica = "Honda";
                    break;
                case "focus":
                case "fiesta":
                    fabrica = "Ford";
                    break;
                case "corolla":
                    fabrica = "Toyota";
                    break;
                case "chevette":
                    fabrica += " Mas você sempre sonhou em ter um Chevette.";
                    break;
                default:
                    fabrica = "Desconhecida!";
                    // Desvio goto:
                    goto case "chevette";
            }
            Console.WriteLine($"A fabricante do seu carro é: {fabrica}.");
        }
    }
}