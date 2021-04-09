using System;

namespace MacorattiCSharp.Aulas
{
    class Aula12
    {
        internal static void Aula()
        {
            // Array de 1 Dimesão (vetores):
            int[] valor1;
            valor1 = new int[5];
            valor1[0] = 1;
            valor1[1] = 2;
            valor1[2] = 3;
            valor1[3] = 4;
            valor1[4] = 5;

            var nomes = new string[2];
            nomes[0] = "Filipe";
            nomes[1] = "Thamara";

            // Formas de declarar uma array:
            int[] n2 = { 10, 20, 30, 40, 50 };
            var n3 = new int[] { 10, 20, 30, 40, 50 };
            var n4 = new int[5] { 10, 20, 30, 40, 50 };
            var n5 = new int[5];
            n5[0] = 10;
            n5[1] = 20;
            n5[2] = 30;
            n5[3] = 40;
            n5[4] = 50;

            var d1 = new double[5];
            var f1 = new float[5];

            // C# inicia array sem atribuição com 0.
            Console.WriteLine(d1[0]);

            // Array de 2 Dimesões (matrizes):
            int[,] numeros = new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            // Array de 3 Dimesões (matrizes):
            int[,,] arr3d = new int[3, 5, 4];
            arr3d[0, 0, 0] = 1;
            arr3d[0, 1, 0] = 2;
            arr3d[0, 2, 0] = 3;
            arr3d[0, 3, 0] = 4;
            arr3d[0, 4, 0] = 5;
            arr3d[1, 1, 1] = 2;
            arr3d[2, 2, 2] = 3;
            arr3d[2, 2, 3] = 4;

            // Arrays irregulares(arrays de arrays) (Jagged Arrays):
            double[][] arrayArray = new double[3][];
            arrayArray[0] = new double[2] { 1.0, 2.0 };
            arrayArray[1] = new double[4] { 3.0, 4.0, 5D, 6D };
            arrayArray[2] = new double[1] { 7D };


            // Percorrendo Arrays
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

            // exibe ‘e’
            Console.WriteLine(vogais[1]);
            for (int i = 0; i < vogais.Length; i++)
            {
                //exibe aeiou
                Console.Write(vogais[i]);
            }

            int[] num = new int[30];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}] = {num[i]}.");
            }

            foreach (int item in num)
            {
                Console.Write($"{item}\t");
            }

            int[,] num2D = new int[3, 2]
            {
                {99, 88},
                {12, 34},
                {100, 56}
            };

            // Percorrendo Array de 2 dimennsões:
            foreach (int item in num2D)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            
            // cria um array tridimensional e percorre o array
            int[,,] arr3D = new int[3, 5, 4];
            arr3D[0, 0, 0] = 1;
            arr3D[0, 1, 0] = 2;
            arr3D[0, 2, 0] = 3;
            arr3D[0, 3, 0] = 4;
            arr3D[0, 4, 0] = 5;
            arr3D[1, 1, 1] = 2;
            arr3D[2, 2, 2] = 3;
            arr3D[2, 2, 3] = 4;

            // percorre cada dimensão do array
            for (int i = 0; i < arr3D.GetLength(2); i++)
            {
                for (int y = 0; y < arr3D.GetLength(1); y++)
                {
                    for (int x = 0; x < arr3D.GetLength(0); x++)
                    {
                        Console.Write(arr3D[x, y, i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}