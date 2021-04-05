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
            central.Add("A2=> Variaveis e Tipos - Variáveis", Aula02.Exercicio);
            central.Add("A2-Ex03=> Variaveis e Tipos - Nome completo", Aula02.Exercicio03);
            central.Add("A3=> Nullable Types - Nullable", Aula03.Exercicio);
            central.Add("A3-Ex01=> Nullable Types - Nullable", Aula03.Exercicio01);
            central.Add("A4=> Variaveis Implicitas Tipadas - VAR", Aula04.Exercicio);
            // Aula04
            central.Add("A5=> Conrtrole de Fluxo - if, else if, else e switch", Aula05.Exercicio);

            central.Add("A6=> Estruturas de Repeticao - While, do/While, for e foreach", Aula06.Exercicio);
            // Aula07
            central.Add("A7=> Switch case", Aula07.Exercicio);
            // Aula08
            central.Add("A8=> Conversão de Tipos", Aula08.Exercicio);
            // Aula09
            central.Add("A9=> Lógica de Programação", Aula09.Exercicio);
            central.Add("A5-Ex02=> Conrtrole de Fluxo - switch", Aula05.Exercicio02);
            
            // Aula06
            central.Add("A6-Ex01=> Estruturas de Repeticao - While, do/While, for e foreach", Aula06.Exercicio01);

            CentralExercicios.SelecionarEExecutar(central);
            Console.Write("Pressione qualquer tecla para encerrar o programa. . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}