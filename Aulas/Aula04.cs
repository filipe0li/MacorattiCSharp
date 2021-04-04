using System;
using System.Collections.Generic;
using System.Linq;

namespace MacorattiCSharp.Aulas
{
    class Aula04
    {
        internal static void Exercicio()
        {
            var i = 5;
            Console.WriteLine(i.GetType());

            var nome0 = "Filipe";
            Console.WriteLine(nome0.GetType());

            /*
             * Não é Possivel converter um tipo int em string, pois var não siguinifica valor variavel!
             * i = "Filipe";
             */

            var vetor = new[] { 0, 1, 2 };
            Console.WriteLine(vetor.GetType());

            var aluno = new { Nome = "Filipe" };
            Console.WriteLine(aluno.GetType());

            var lista = new List<int>();
            Console.WriteLine(lista.GetType());

            string[] nomes = { "Filipe", "Thamara" };
            IEnumerable<string> consulta = from nome in nomes
                                           where nome[0] == 'F'
                                           select nome;
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            var consulta1 = from nome in nomes
                            where nome[0] == 'T'
                            select nome;
            foreach (var item in consulta1)
            {
                Console.WriteLine(item);
            }

            /*
             * Vale a pena usar VAR
             * ClasseComNomeMuitoGrandeDeDigitar<string> obj = new ClasseComNomeMuitoGrandeDeDigitar<string>();
             * var obj1 = new ClasseComNomeMuitoGrandeDeDigitar<string>();
             */

            IEnumerable<Filipe> consulta2 = from nome in nomes
                                            where nome.Length > 5
                                            select new Filipe { Tamanho = nome.Length, Valor = nome };
            foreach (var item in consulta2)
            {
                Console.WriteLine(item.Valor);
            }

            var consulta3 = from nome in nomes
                            where nome.Length > 5
                            select new { Tamanho = nome.Length, Valor = nome };

            foreach (var item in consulta3)
            {
                Console.WriteLine(item.Valor);
            }

            /*
             * Permitido normalmente:
             * int a = (a = 20);
             * int c = 5, d = 6;
             */

            /*
             * var não permite:
             * var b = (b = 20);
             * var nome1;
             * var nome2 = null;
             * var e = 5, f = 6;
             */
        }
    }
    class Filipe
    {
        // Foi necessário devido oa não uso de var, logo foi necessário a implementção de um tipo(class).
        public int Tamanho;
        public string Valor;
    }
}
