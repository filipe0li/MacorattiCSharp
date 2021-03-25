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
                int aula;
                int.TryParse(Console.ReadLine(), out aula);
                Console.Clear();
                switch (aula)
                {
                    case 2:
                        Aula02.Aula();
                        break;

                    case 3:
                    //Aula03.Aula();
                    default:
                        continuar = false;
                        break;
                }
            }
        }
    }
}
