using System;
using System.Linq;

namespace ЛР_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int, int, char) LocalFunction(int[] arr, string str)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), str[0]);
            }

            int[] arr1 = {5, 23 -8, 14, 9, -1, 6, 2};
            string txt = "Kluv";
            Console.WriteLine(LocalFunction(arr1, txt));
        }
    }
}