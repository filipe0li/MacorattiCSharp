using System;

namespace MacorattiCSharp.Aulas
{
    class Aula09
    {
        internal static void Exercicio()
        {
            int numero1, numero2, numero3, menorNumero;
            string letra = "";
            while (letra != "S")
            {
                Console.Write("Informe o primeiro nº inteiro: ");
                int.TryParse(Console.ReadLine(), out numero1);

                Console.Write("Informe o segundo nº inteiro: ");
                int.TryParse(Console.ReadLine(), out numero2);

                Console.Write("Informe o terceiro nº inteiro: ");
                int.TryParse(Console.ReadLine(), out numero3);

                Console.WriteLine("------------- Resultado --------------------------");

                if ((numero1 < numero2) && (numero1 < numero3))
                {
                    menorNumero = numero1;
                }
                else if (numero2 < numero3)
                {
                    menorNumero = numero2;
                }
                else
                {
                    menorNumero = numero3;
                }
                Console.WriteLine($"O menor número entre os números {numero1}, {numero2}, {numero3} é o número {menorNumero}.");
                Console.Write("Pressione S para Sair ou qualquer outra tecla para continuar...");
                letra = Console.ReadLine().ToUpper();
            }
        }
    }
}