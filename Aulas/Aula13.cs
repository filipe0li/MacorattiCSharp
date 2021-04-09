using System;
using Mensagem = Brasil.RS.Filipe.Teste;
using A.B.C;

namespace MacorattiCSharp.Aulas
{
    class Aula13
    {
        internal static void Aula()
        {
            Teste.Saldacao.BemVindo();
            Brasil.Program.Exibir("Brasil.Program.Exibir");
            Brasil.Program.Main();
            Mensagem.Exibir("('alias') Mensagem = Brasil.RS.Filipe.Teste");
        }
    }
    namespace Teste
    {
        class Saldacao
        {
            internal static void BemVindo()
            {
                Console.WriteLine("Bem-Vindo!\n-----------");
            }
            internal static void Exibir(string texto)
            {
                Console.WriteLine(texto);
            }
        }
    }
}
namespace Brasil
{
    class Program
    {
        internal static void Main()
        {
            MacorattiCSharp.Aulas.Teste.Saldacao.Exibir("Teste.Saldacao.Exibir");
        }
        internal static void Exibir(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
namespace Brasil.RS
{
    namespace Filipe
    {
        class Teste
        {
            internal static void Exibir(string texto)
            {
                Console.WriteLine(texto);
            }
        }
    }

}
namespace E
{
    using D;

    class Program
    {

        //Este exemplo tem namespaces com os identificadores A, B, C, D, E e F. 
        //Os Namespaces B e C estão aninhados dentro dos Namespaces namespace A. 
        //Os namespaces D, E e F estão todos no nível superior da unidade de compilação. 
        //Na classe Program, observe como o ponto de entrada Main usa os tipos CClass, DClass e Fclass. 
        //Como as diretivas using A.B.C e using D estão presentes no namespace E , o método Main 
        //pode usar esses tipos diretamente. 
        //Com FClass, o namespace deve ser especificado explicitamente porque F não está incluído dentro
        //de E com uma directiva using.
        static void Main(string[] args)
        {
            // Pode acessar o tipo CClass diretamente a partir de A.B.C.
            CClass var1 = new CClass();

            // Pode acessar o tipo DClass a partir de D
            DClass var2 = new DClass();

            // Precisa especificar explicitamente o namespace F
            F.FClass var3 = new F.FClass();

            // saida
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.ReadKey();
        }
    }
}
namespace A
{
    namespace B
    {
        namespace C
        {
            public class CClass
            {
            }
        }
    }
}
namespace D
{
    public class DClass
    {
    }
}
namespace F
{
    public class FClass
    {
    }
}