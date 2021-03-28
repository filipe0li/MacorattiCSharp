using System;
using System.Collections.Generic;
using MacorattiCSharp.Aulas;

namespace MacorattiCSharp
{
    class Program
    {
        static void Main()
        {
            var central = new Dictionary<string, Action>();

            // Aula02
            central.Add("A2-Ex01=> Variaveis e Tipos - Variáveis", Aula02.Exercicio01);
            central.Add("A2-Ex02=> Variaveis e Tipos - Área do circulo", Aula02.Exercicio02);
            central.Add("A2-Ex03=> Variaveis e Tipos - Nome completo", Aula02.Exercicio03);

            // Aula03
            central.Add("A3-Ex01=> Nullable Types - Nullable", Aula03.Exercicio01);
            central.Add("A3-Ex02=> Nullable Types - Nullable", Aula03.Exercicio02);
            
            // Aula04
            central.Add("A4-Ex01=> Variaveis Implicitas Tipadas - VAR", Aula04.Exercicio01);
            central.Add("A4-Ex02=> Variaveis Implicitas Tipadas - VAR", Aula04.Exercicio02);

            // Aula05
            central.Add("A5-Ex01=> Conrtrole de Fluxo - if, else if, else", Aula05.Exercicio01);
            central.Add("A5-Ex02=> Conrtrole de Fluxo - switch", Aula05.Exercicio02);

            CentralExercicios.SelecionarEExecutar(central);
            Console.Write("Pressione qualquer tecla para encerrar o programa. . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}