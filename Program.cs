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
            central.Add("A02=> Variaveis e Tipos - Variáveis", Aula02.Exercicio);
            // Aula03
            central.Add("A03=> Nullable Types - Nullable", Aula03.Exercicio);
            // Aula04
            central.Add("A04=> Variaveis Implicitas Tipadas - VAR", Aula04.Exercicio);
            // Aula05
            central.Add("A05=> Conrtrole de Fluxo - if, else if, else e switch", Aula05.Exercicio);
            // Aula06
            central.Add("A06=> Estruturas de Repeticao - While, do/While, for e foreach", Aula06.Exercicio);
            // Aula07
            central.Add("A07=> Switch case", Aula07.Exercicio);
            // Aula08
            central.Add("A08=> Conversão de Tipos", Aula08.Exercicio);
            // Aula09
            central.Add("A09=> Lógica de Programação", Aula09.Exercicio);
            // Aula10
            central.Add("A10=> Enum", Aula10.Exercicio);
            CentralExercicios.SelecionarEExecutar(central);
            Console.Write("Pressione qualquer tecla para encerrar o programa. . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}