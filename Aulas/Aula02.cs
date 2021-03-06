using System;

namespace MacorattiCSharp.Aulas
{
    class Aula02
    {
        internal static void Aula()
        {
            int x;
            int y;

            x = 100;
            Console.WriteLine($"x contém o valor = {x}.");

            y = x / 2;
            x = y + 100;

            Console.WriteLine($"y contém o valor de x / 2 = {x}.");

            Console.WriteLine($"x contém o valor de y + 100 = {x}.");

            /*
             * Calcula área do circulo A = PI * Raio * Raio
             * Autor Filipe
             */

            float raioCirculo, areaCirculo;
            const float VALORPI = 3.1416F;
            raioCirculo = 10.0F;
            areaCirculo = (raioCirculo * raioCirculo * VALORPI);

            Console.WriteLine($"A área do circulo de raio {raioCirculo} é {areaCirculo}.");

            string primeiroNome = "Filipe";
            string sobrenome = "Barbosa";

            int a = 10;
            int b = 40;

            Console.WriteLine($"O seu nome completo é {primeiroNome} {sobrenome}.");
            Console.WriteLine($"{a} + {b} = {a + b}.");
        }
    }
}
