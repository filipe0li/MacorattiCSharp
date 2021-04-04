using System;

namespace MacorattiCSharp.Aulas
{
    enum Volume
    {
        Baixo,
        Medio,
        Alto,
        Indefinido
    }
    class Aula07
    {
        internal static void Exercicio()
        {
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero);

            switch (numero)
            {
                case 10:
                // Console.WriteLine($"O número digitado foi: {numero}.");
                // break;
                case 20:
                // Console.WriteLine($"O número digitado foi: {numero}.");
                // break;
                case 30:
                    Console.WriteLine($"O número digitado foi: {numero}.");
                    break;
                default:
                    Console.WriteLine("O número digitado não é 10, 20 ou 30.");
                    break;
            }

            Console.Write("Digite a nota do aluna (A, B, C, D, F): ");
            string nota = Console.ReadLine().ToUpper();
            switch (nota)
            {
                case "A":
                    Console.WriteLine("Excelente!");
                    break;
                case "B":
                case "C":
                    Console.WriteLine("Muito Bem!");
                    break;
                case "D":
                    Console.WriteLine("Recuperação!");
                    break;
                case "F":
                    Console.WriteLine("Reprovado!");
                    break;
                default:
                    Console.WriteLine("Nota inválida!");
                    break;
            }
            Console.WriteLine($"Nota do Aluno é {nota}.");

            Volume volume = Volume.Indefinido;
            switch (volume)
            {
                case Volume.Baixo:
                    Console.WriteLine("O volume está baixo.");
                    break;
                case Volume.Medio:
                    Console.WriteLine("O volume está médio.");
                    break;
                case Volume.Alto:
                    Console.WriteLine("O volume está alto.");
                    break;
                default:
                    Console.WriteLine("Indefinido!");
                    break;
            }

            int num = 0;
            Console.Write("Digite um nº: ");
            int.TryParse(Console.ReadLine(), out num);

            switch (num)
            {
                case 10:
                    Console.WriteLine($"Você digitou: {num}.");
                    break;
                case 20:
                    Console.Write($"Você digitou: {num}");
                    num += 10;
                    Console.Write(", mas somamos 10, logo. ");
                    goto case 30;
                case 30:
                    Console.WriteLine($"Você digitou: {num}.");
                    break;
                default:
                    Console.WriteLine("O número digitado não é 10, 20 ou 30.");
                    break;
            }
        }
    }
}