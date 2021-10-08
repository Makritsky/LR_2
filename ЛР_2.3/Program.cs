using System;
using Microsoft.CSharp.RuntimeBinder;

namespace ЛР_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№3-Массивы");
            
            Console.WriteLine("№3-a)");
            Console.WriteLine("Вывод рандомного двумерного массива: ");
            int[,] myArr = new int[3, 3];
            Random ran = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ввод элементов массива с клавиатуры: ");
            Console.WriteLine("Введите размерность массива");
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            
            var mass = new int[n, m];
 
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("№3-b)");
            string[] cifry = { "Nolb", "Odin", "Dva",
                "Try", "ChetbIre", "Patb" };
            for (int i = 0; i < cifry.Length; i++)
                Console.WriteLine("elem[{0}] = {1}", i, cifry[i]);

            var l = cifry.Length;
            Console.WriteLine(l);
            
            Console.WriteLine("Введите номер элемента массива, который нужно заменить:");
            var o = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите строку, на которую нужно заменить элемент:");
            var p = Console.ReadLine();
            for (int i = 0; i < cifry.Length; i++)
            {
                if (i == o)
                {
                    cifry[i] = p;
                }
                Console.WriteLine("elem[{0}] = {1}", i, cifry[i]);
            }

            Console.WriteLine("№3-c)");
            var y = 0;
            int[][] stupArr = new int[3][];
            stupArr[0] = new int[2];
            stupArr[1] = new int[3];
            stupArr[2] = new int[4];

            Random random = new Random();

            for (int i = 0; i < stupArr.Length; i++)
            {
                for (int j = 0; j < stupArr[i].Length; j++)
                {
                    stupArr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ступенчатый массив: ");
            for (int i = 0; i < stupArr.Length; i++)
            {
                for (int j = 0; j < stupArr[i].Length; j++)
                {
                    Console.Write(stupArr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("№3-d)");
            var s = "Allo";
            var a = new[] { 0, 1, 2 };
        }
    }
}