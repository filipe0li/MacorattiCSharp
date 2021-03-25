using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacorattiCSharp.Aulas
{
    class Aula02
    {
        internal static void Aula()
        {
            int x;
            int y;

            x = 100;
            Console.WriteLine("x contém o valor = " + x);

            y = x / 2;
            x = y + 100;

            Console.WriteLine("y contém o valor de x / 2 = " + y);

            Console.WriteLine("x contém o valor de y + 100 = " + x);
        }
    }
}
