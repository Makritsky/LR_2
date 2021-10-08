using System;
using System.Runtime.InteropServices.ComTypes;

namespace ЛР_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№4-a)");
            (int, string, char, string, ulong) k = (1, "dva", '3', "chetbIre", 5);
            
            
            Console.WriteLine("№4-b)");
            Console.WriteLine("Кортеж k: " + k);
            Console.WriteLine($"Первый и четвертый элементы кортежа: {k.Item1}; {k.Item4}");
            
            Console.WriteLine("№4-c)");
            var (один, два, три, четыре, пять) = k;
            Console.WriteLine($"Распаковка кортежа в переменные: \n один: {один} \n два: {два} \n три: {три} \n четыре: {четыре} \n пять: {пять} ");

            Console.WriteLine("№4-d)");
            (int, string) k1 = (123, "abc");
            (int, string) k2 = (124, "abc");
            Console.WriteLine($"Кортежи k1 и k2 равны: {k1==k2}");
            Console.WriteLine($"Кортежи k1 и k2 не равны: {k1!=k2}");
        }
    }
}