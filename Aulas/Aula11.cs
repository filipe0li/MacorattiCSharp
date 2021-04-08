using System;

namespace MacorattiCSharp.Aulas
{
    class Aula11
    {
        internal static void Aula()
        {
            // Operadores aritiméticos: +, -, *, / e %
            int a = 10;
            int b = 20;
            int resultado = a + b;
            Console.WriteLine($"A soma de A: {a} + B: {b} = {resultado}.");

            resultado = a - b;
            Console.WriteLine($"A subtração de A: {a} - B: {b} = {resultado}.");

            resultado = a * b;
            Console.WriteLine($"A multiplicação de A: {a} * B: {b} = {resultado}.");

            if (b != 0)
            {
                resultado = a / b;
                Console.WriteLine($"A divisão de A: {a} / B: {b} = {resultado}.");
                resultado = a % b;
                Console.WriteLine($"O resto de A: {a} % B: {b} = {resultado}.");
            }
            else
            {
                Console.WriteLine("Impossível dividir por 0.");
            }

            double elevado = Math.Pow(a, b);
            Console.WriteLine($"A: {a} elevado a B: {b} = {elevado}.");

            double raiz = Math.Sqrt(a);
            // :F formata para 2 casas decimais após a virgula.
            Console.WriteLine($"A raiz quadrade de A: {a} = {raiz:F}.");

            // Operadores aritiméticos com atribuição
            int salario = 1000;
            salario += 100; // salario = salario + salario;
            Console.WriteLine($"Operador += {salario}.");

            salario -= 100; // salario = salario - salario;
            Console.WriteLine($"Operador -= {salario}.");

            salario *= 100; // salario = salario * salario;
            Console.WriteLine($"Operador *= {salario}.");

            salario /= 100; // salario = salario / salario;
            Console.WriteLine($"Operador /= {salario}.");

            salario %= 100; // salario = salario % salario;
            Console.WriteLine($"Operador %= {salario}.");

            // Operadores ++ --
            int i = 1000;
            i++; // i = i + 1;
            Console.WriteLine($"Operador i++ {i}.");

            i--; // i = i - 1;
            Console.WriteLine($"Operador i-- {i}.");

            // Prefixo e Sufixo
            // PREFIXO: Primeiro incrementa depois atribui:
            int valor1;
            int valor2 = 10;
            valor1 = ++valor2; // Primeiro valor2 recebe o incremento, depois é feito a atribuição de valor2 à valor1.
            Console.WriteLine($"Valor1 = {valor1}.\nValor2 = {valor2}.");

            // SUFIXO: Primeiro atribui depois incrementa:
            int valor3;
            int valor4 = 10;
            valor3 = valor4++; // Primeiro valor4 é atribuido à valor3, depois é feito o incremento à valor4.
            Console.WriteLine($"Valor3 = {valor3}.\nValor4 = {valor4}.");

            // operadores relacionais
            int j = 10;
            int k = 11;

            if (j < k) { Console.WriteLine($"{j} < {k}"); }
            if (j <= k) { Console.WriteLine($"{j} <= {k}"); }
            if (j != k) { Console.WriteLine($"{j} != {k}"); }
            if (j == k) { Console.WriteLine("Não será executado!"); }
            if (j >= k) { Console.WriteLine("Não será executado!"); }
            if (j > k) { Console.WriteLine("Não será executado!"); }

            // && se o primeiro a ser ajaliado for false já retorna false, sem conferir os demais.
            // || se o primeiro a ser ajaliado for true já rettorna true, sem conferir os demais.
            // & avalia todos, mesmo se algum já tenha retornado false.
            // | avalia todos, mesmo se algum já tenha retornado true.
            bool b1 = true;
            bool b2 = false;

            if (b1 & b2) { Console.WriteLine("Não será executado!"); }
            if (!(b1 & b2)) { Console.WriteLine("!(b1 & b2) é true."); }
            if (b1 | b2) { Console.WriteLine("(b1 | b2) é true."); }
            if (b1 ^ b2) { Console.WriteLine("(b1 ^ b2) é true."); }

            int n = 10;
            int d = 2;

            // d é diferente de 0 e 10 % 2 tem %(resto) = 0
            if (d != 0 && (n % d) == 0)
            {
                Console.WriteLine($"{d} é o tator de {n}.");
            }

            d = 0;
            // Como d = 0, a segunda condição não será verificada, pois é impossível uma divisão por 0, isto causa uma exception.
            if (d != 0 && (n % d) == 0)
            {
                Console.WriteLine($"{d} é o tator de {n}.");
            }
            else
            {
                Console.WriteLine("Não avaliou o segundo termo, como prova, é impossível dividir por 0.");
            }

            // Operador &, verifica todas condições.
            // Vai ocorrer uma divisão por 0, isto causa uma exception.
            try
            {
                if (d != 0 & (n % d) == 0)
                {
                    Console.WriteLine($"{d} é o tator de {n}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Avaliou o segundo termo e causou uma divisão por 0.\nNão vai executar.\n{ex.Message}");
            }

            // Operador ternário
            Console.Write("Inform o sex: M ou F: ");
            string sexo = Console.ReadLine().ToUpper();

            Console.WriteLine(sexo == "M" ? "Masculino" : "Feminino");

            int aa = 10 - 2 * 3;
            Console.WriteLine($"aa = 10 - 2 * 3 = {aa}");

            int bb = (10 - 2) * 3;
            Console.WriteLine($"bb = (10 - 2) * 3 = {bb}");
        }
    }
}