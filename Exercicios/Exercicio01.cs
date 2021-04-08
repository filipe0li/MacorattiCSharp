using System;

namespace MacorattiCSharp.Exercicios
{
    class Exercicio01
    {
        internal static void Exercicio()
        {
            Console.Write("Digite o nº (1 - 12) do exercício: ");
            int.TryParse(Console.ReadLine(), out int entrada);
            switch (entrada)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 7:
                    Exercicio7();
                    break;
                case 8:
                    Exercicio8();
                    break;
                case 9:
                    Exercicio9();
                    break;
                case 10:
                    Exercicio10();
                    break;
                case 11:
                    Exercicio11();
                    break;
                case 12:
                    Exercicio12();
                    break;
                default:
                    Console.WriteLine("Exercício não encontrado!");
                    break;
            }
        }
        static void Exercicio1()
        {
            Console.Write("Digite um nº: ");
            int.TryParse(Console.ReadLine(), out int n1);

            Console.Write("Digite outo nº: ");
            int.TryParse(Console.ReadLine(), out int n2);

            int soma = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {soma}.");

            int subtracao = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {subtracao}.");

            int multiplicacao = n1 * n2;
            Console.WriteLine($"{n1} x {n2} = {multiplicacao}.");

            int divisao, resto = 0;
            if (n2 == 0)
            {
                Console.WriteLine("Impossível dividir por 0.");
            }
            else
            {
                divisao = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {divisao}.");
                resto = n1 % n2;
                Console.WriteLine($"{n1} mod {n2} = {resto}.");
            }
        }
        static void Exercicio2()
        {
            Console.Write("Digite um nº: ");
            int.TryParse(Console.ReadLine(), out int n1);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n1} x {i} = {n1 * i}");
            }
        }
        static void Exercicio3()
        {
            Console.Write("Digite um a temperatura em ºC: ");
            int.TryParse(Console.ReadLine(), out int celsius);

            double kelvin = celsius + 273.15;
            Console.WriteLine($"Temperatura em Kelvin = {kelvin:F} K.");

            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"Temperatura em Fahrenheit = {fahrenheit:F} ºF.");
        }
        static void Exercicio4()
        {
            var numeros = new int[3];
            Console.Write("Digite 3 nº: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out numeros[i]);
            }
            if (numeros[0] > numeros[1] && numeros[0] > numeros[2])
            {
                Console.WriteLine($"{numeros[0]} é o maior nº.");
            }
            else if (numeros[1] > numeros[2])
            {
                Console.WriteLine($"{numeros[1]} é o maior nº.");
            }
            else
            {
                Console.WriteLine($"{numeros[2]} é o maior nº.");
            }
        }
        static void Exercicio5()
        {
            Console.Write("Digite um nº: ");
            int.TryParse(Console.ReadLine(), out int entrada);

            while (entrada != 0)
            {
                Console.WriteLine($"10 x {entrada}.");

                Console.Write("Digite um nº: ");
                int.TryParse(Console.ReadLine(), out entrada);
            }
            Console.WriteLine("Encerrado!");
        }
        static void Exercicio6()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void Exercicio7()
        {
            int login = 12;
            int senha = 123;
            int entradaLogin, entradaSenha;
            bool sucesso;

            do
            {
                Console.Write("Digite o login: ");
                int.TryParse(Console.ReadLine(), out entradaLogin);

                Console.Write("Digite a senha: ");
                int.TryParse(Console.ReadLine(), out entradaSenha);
                sucesso = entradaLogin == login && entradaSenha == senha;
                if (sucesso)
                {
                    Console.WriteLine("Logado com sucesso!");
                    break;
                }
                Console.Clear();
                Console.WriteLine("Login Inválido!");
            } while (!sucesso);
        }
        static void Exercicio8()
        {
            Console.WriteLine("Incremento de 1:");
            for (int i = 10; i <= 20; i++)
            {
                if (i == 16)
                {
                    continue;
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Incremento de 2:");
            for (int i = 10; i <= 20; i += 2)
            {
                if (i == 16)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop infinito:");
            for (int i = 10; ; i += 2)
            {
                if (i == 16)
                {
                    continue;
                }
                else if (i > 20)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        static void Exercicio9()
        {
            Console.Write("Digite a nota do aluno de 0 - 10: ");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota <= 4)
            {
                Console.WriteLine("Reprovado!");
            }
            else if (nota == 5)
            {
                Console.WriteLine("Regular!");
            }
            else if (nota == 6)
            {
                Console.WriteLine("Bom!");
            }
            else if (nota <= 8)
            {
                Console.WriteLine("Notável!");
            }
            else
            {
                Console.WriteLine("Excelente!");
            }

            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Reprovado!");
                    break;
                case 5:
                    Console.WriteLine("Regular!");
                    break;
                case 6:
                    Console.WriteLine("Bom!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notável!");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Excelente!");
                    break;
                default:
                    Console.WriteLine("Nota inválida!");
                    break;
            }
        }
        static void Exercicio10()
        {
            int n1, n2, resultado;
            Console.Write("Digite um nº: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Digite outo nº: ");
            int.TryParse(Console.ReadLine(), out n2);

            try
            {
                resultado = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {resultado}.");
                resultado = n1 % n2;
                Console.WriteLine($"{n1} mod {n2} = {resultado}.");
            }
            catch (Exception)
            {
                Console.WriteLine("Impossível dividir por 0.");
            }
        }
        static void Exercicio11()
        {
            int largura, altura;
            do
            {
                Console.Write("Digite a largura: ");
                int.TryParse(Console.ReadLine(), out largura);
                if (largura == 0)
                {
                    break;
                }

                Console.Write("Digite a altura: ");
                int.TryParse(Console.ReadLine(), out altura);
                if (altura == 0)
                {
                    break;
                }

                Console.WriteLine($"Perímetro: {altura * 2 + largura * 2}.");
                Console.WriteLine($"Área: {altura * largura}.");
                Console.WriteLine($"Diagonal: {Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2)):F}.");

            } while (true);
            Console.Write("Encerrado!");
        }
        static void Exercicio12()
        {
            int n1, n2;
            Console.Write("Digite um nº: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Digite outo nº: ");
            int.TryParse(Console.ReadLine(), out n2);

            bool ambos = n1 % 2 == 0 && n2 % 2 == 0 ? true : false;

            Console.WriteLine(ambos ? "Ambos são pares!" : "Um ou os 2 são ímpares!");

        }
    }
}