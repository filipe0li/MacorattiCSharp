using System;

namespace MacorattiCSharp.Aulas
{
    class Aula03
    {
        internal static void Exercicio01()
        {
            int valor;
            int? valorNull = null;

            //Casting conhecidos, forçados(explicitamente):
            if (valorNull != null)
            {
                valor = (int)valorNull;
                valor = valorNull.Value;
            }

            // Casting com segurança(explicitamente):
            Console.WriteLine(valorNull.ToString());
            valor = valorNull.GetValueOrDefault();

            Console.WriteLine(valor);

            //string nome = null;
            //int? valor1 = null;

            // Forma não abreviada de um Nullable:
            //Nullable<int> valor2 = null;

            //double? valor3 = 3.14;
            //bool? valor4 = null;
            //char? valor5 = 'A';
            //int?[] array = new int?[10];
        }
        internal static void Exercicio02()
        {
            int? valor = 100;
            int valInt = (int)valor;
            Console.WriteLine(valor);

            DateTime? dataNascimento = null;
            //dataNascimento = new DateTime(1991, 08, 08);
            if (dataNascimento.HasValue)
            {
                Console.WriteLine($"Data de nescimento foi definida");
            }
            else
            {
                Console.WriteLine($"Data de nescimento é null");
            }

            try
            {
                Console.WriteLine(dataNascimento.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro! {ex.Message}");
            }
        }
    }
}
