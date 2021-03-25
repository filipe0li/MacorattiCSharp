using System;
using MacorattiCSharp.Aulas;

namespace MacorattiCSharp
{
    class Program
    {
        static void Main()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Qual nº da aula que deseja executar?");
                int exercicio;
                int.TryParse(Console.ReadLine(), out exercicio);
                Console.Clear();
                switch (exercicio)
                {
                    case 1:
                        Aula02.Exercicio01();
                        break;

                    case 2:
                        Aula02.Exercicio02();
                        break;

                    case 3:
                        //Aula02.Exercicio01();
                        break;

                    default:
                        continuar = false;
                        break;
                }
            }
        }
    }
}
