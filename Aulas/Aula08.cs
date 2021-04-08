using System;

namespace MacorattiCSharp.Aulas
{
    // Classe Base
    class Retangulo
    {
        protected int x = 10, y = 10;
        int GetArea()
        {
            return x * y;
        }
    }
    // Classe Derivada
    // A classe Quadrado é uma especializaçãoda classe base
    // Assim um Quadrado é um tipo de Retangulo
    class Quadrado : Retangulo
    {
        int getPerimetro()
        {
            return (2 * x + 2 * y);
        }
    }
    class Aula08
    {
        internal static void Aula()
        {
            int a = 1234567;
            double b = a; // Conversão implícita, sem perca de precisão.
            Console.WriteLine($"Variavel DOUBLE b: {b}.");

            double c = 123.456;
            int d = (int)c; // Conversão explicita "Casting", com perca de precisão.
            Console.WriteLine($"Variavel INT d: {d}.");

            double e = 123.456;
            int f = (int)e;
            decimal g = (decimal)f;
            Console.WriteLine($"Variavel DECIMAL d: {g}.");

            string numero = "2000";
            // Usando Contert
            int valor1 = Convert.ToInt32(numero);
            short valor2 = Convert.ToInt16(numero);
            double valor3 = Convert.ToDouble(numero);
            DateTime data = Convert.ToDateTime($"20/10/{numero}");
            Console.WriteLine("Usando Contert.ToXXXX:");
            Console.WriteLine($"{valor1}\n{valor2}\n{valor3}\n{data}");

            // Usando Parse
            int valorP1 = int.Parse(numero);
            short valorP2 = short.Parse(numero);
            double valorP3 = double.Parse(numero);
            DateTime dataP = DateTime.Parse($"20/10/{numero}");
            Console.WriteLine("Usando Parse.ToXXXX:");
            Console.WriteLine($"{valorP1}\n{valorP2}\n{valorP3}\n{dataP}");

            // string
            int h = 100;
            string valorH = h.ToString();
            string valorHP = Convert.ToString(h);
            Console.WriteLine($"Variavel STRING h: {valorH}.\nVariavel STRING h: {valorHP}.");

            // Tipos diferentes
            var q = new Quadrado();
            // Conversão implicita só foi possivel, pois a classe Quadrado(DERIVADA) herda da clase Retangulo(BASE).
            Retangulo r = q;

            // Conversão explicita "Casting" não foi possivel implícitamente, pois a classe Quadrado(DERIVADA) não herda da clase Retangulo(BASE).
            Quadrado q1 = (Quadrado)r;
        }
    }
}