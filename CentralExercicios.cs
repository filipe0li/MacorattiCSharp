using System;
using System.Collections.Generic;
using System.Linq;

namespace MacorattiCSharp
{
    class CentralExercicios
    {
        internal static void SelecionarEExecutar(Dictionary<string, Action> exercicios)
        {
            int index = 0;
            foreach (var item in exercicios)
            {
                Console.WriteLine($"{index}) {item.Key}");
                index++;
            }

            Console.Write("Digite o número (ou vazio para o último)? ");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            if (num > 0 && num <= exercicios.Count)
            {
                num--;
            }
            else
            {
                num = exercicios.Count - 1;
            }
            KeyValuePair<string, Action> exercicioSelecionado = exercicios.ElementAt(num);

            Console.Clear();
            Console.Write("Executando exercício ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(exercicioSelecionado.Key);
            Console.ResetColor();

            string espacamento = null;
            for (int i = 0; i < (exercicioSelecionado.Key.Length + 21); i++)
            {
                espacamento += '=';
            }
            Console.WriteLine(espacamento);

            Action executar = exercicioSelecionado.Value;
            try
            {
                executar();
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                Console.ResetColor();
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}