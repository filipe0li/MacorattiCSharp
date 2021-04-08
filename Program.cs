using System;
using System.Collections.Generic;
using MacorattiCSharp.Aulas;
using MacorattiCSharp.Exercicios;

namespace MacorattiCSharp
{
    class Program
    {
        static void Main()
        {
            var central = new Dictionary<string, Action>();
            // Aula02
            central.Add("A02=> Variaveis e Tipos - Variáveis", Aula02.Aula);
            // Aula03
            central.Add("A03=> Nullable Types - Nullable", Aula03.Aula);
            // Aula04
            central.Add("A04=> Variaveis Implicitas Tipadas - VAR", Aula04.Aula);
            // Aula05
            central.Add("A05=> Conrtrole de Fluxo - if, else if, else e switch", Aula05.Aula);
            // Aula06
            central.Add("A06=> Estruturas de Repeticao - While, do/While, for e foreach", Aula06.Aula);
            // Aula07
            central.Add("A07=> Switch case", Aula07.Aula);
            // Aula08
            central.Add("A08=> Conversão de Tipos", Aula08.Aula);
            // Aula09
            central.Add("A09=> Lógica de Programação", Aula09.Aula);
            // Aula10
            central.Add("A10=> Enum", Aula10.Aula);
            // Aula11
            central.Add("A11=> Operadores", Aula11.Aula);
            // Exercício01
            central.Add("E01=> Exercicio01", Exercicio01.Exercicio);
            
            CentralExercicios.SelecionarEExecutar(central);
            Console.Write("Pressione qualquer tecla para encerrar o programa. . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}