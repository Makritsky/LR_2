using System;

namespace ЛР_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            void f1()
            {
                unchecked
                {
                    int maxint = 2147483647;
                    maxint = maxint + 1;
                    Console.WriteLine(maxint);
                }
            }
            void f2()
            {
                checked
                {
                    int maxint = 2147483647;
                    maxint += 1;
                    Console.WriteLine(maxint);
                }
            }

            Console.Write("Номер функции: ");
            var sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1: f1(); break;
                case 2: f2(); break;
            }
        }
    }
}