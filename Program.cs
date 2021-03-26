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
            central.Add("Variaveis e Tipos - Variáveis - Ex01", Aula02.Exercicio01);
            central.Add("Variaveis e Tipos - Área do circulo - Ex02", Aula02.Exercicio02);
            central.Add("Variaveis e Tipos - Nome completo - Ex03", Aula02.Exercicio03);

            // Aula03
            central.Add("Nullable Types - Nullable - Ex01", Aula03.Exercicio01);
            central.Add("Nullable Types - Nullable - Ex02", Aula03.Exercicio02);
            
            CentralExercicios.SelecionarEExecutar(central);
            Console.Write("Pressione qualquer tecla para continuar. . . "); Console.ReadLine();
        }
    }
}