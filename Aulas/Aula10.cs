using System;

namespace MacorattiCSharp.Aulas
{
    class Aula10
    {
        enum EstadoCivil
        {
            Casado, Solteiro, Viuvo, Divorciado
        }
        enum DiaSemana
        {
            Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo
        }
        enum DiaMes : byte
        {
            Janeiro, Fevereiro, Marco, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro
        }
        enum Estado
        {
            Desligado = 0,
            Ligado = 5,
            Repouso = 10,
            Processsando = Ligado + 10
        }
        internal static void Aula()
        {
            var dia = DiaSemana.Domingo;
            Console.WriteLine($"Hoje é dia: {dia}.");

            int x = (int)DiaSemana.Domingo;
            Console.WriteLine($"Hoje é o dia: {x}.");

            // Pega nome do Enum pelo número:
            string s = Enum.GetName(typeof(DiaSemana), 4);
            Console.WriteLine($"Dia da semana 4 = {s}.");

            Console.Write($"Os valores do enum (GetValues) DiaDemana são: ");
            foreach (int item in Enum.GetValues(typeof(DiaSemana)))
            {
                Console.Write($"{item}\t");
            }
            Console.Write("\n");

            Console.Write($"Os nomes do enum (GetNames) DiaDemana são: ");
            foreach (string item in Enum.GetNames(typeof(DiaSemana)))
            {
                Console.Write($"{item}\t");
            }
            Console.Write("\n");

            static void Estado_Civil(EstadoCivil s)
            {
                switch (s)
                {
                    case EstadoCivil.Solteiro:
                        Console.WriteLine("Solteiro\n");
                        break;
                    case EstadoCivil.Casado:
                        Console.WriteLine("Casado\n");
                        break;
                    case EstadoCivil.Viuvo:
                        Console.WriteLine("´Viúvo\n");
                        break;
                    case EstadoCivil.Divorciado:
                        Console.WriteLine("Divorciado\n");
                        break;
                }
            }
            Estado_Civil(EstadoCivil.Casado);
        }
    }
}