using System;
using System.Text;

namespace ЛР_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№2-СТРОКИ");
            
            Console.WriteLine("№2-a)");
            string s1 = "Odin";
            string s2 = "Odin";
            string s3 = "Dva";
            Console.WriteLine("s1 == s2: " + (s1 == s2));   // True
            Console.WriteLine("s1 != s2: " + (s1 != s2));   // False
            Console.WriteLine("s1 == s3: " + (s1 == s3));   // False

            Console.WriteLine("№2-b)");
            Console.WriteLine("Сцепление строк:");
            string s4 = s2 + " " + s3;
            string s5 = String.Concat(s4, " Tri"); 
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            
            Console.WriteLine("Копирование строк:");
            string s6 = String.Copy(s4);
            Console.WriteLine("Копирование строки s4: " + s6);
            
            Console.WriteLine("Выделение подстроки:");
            string sub_s = s1.Substring(2);
            Console.WriteLine("Подстрока строки s2: " + sub_s);
            
            Console.WriteLine("Разделение строки на слова:");
            string[] split_s = s5.Split(new char[] { ' ' });
            foreach (string s in split_s)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Вставка подстроки в заданную позицию:");
            string s7 = s5.Insert(12, " ChetbIre");
            Console.WriteLine(s7);
            
            Console.WriteLine("Удаление заданной подстроки:");
            string s8 = s7.Remove(0, 5);
            Console.WriteLine(s8);
            
            Console.WriteLine("Интерполирование строк:");
            int x = 123;
            int y = 456;
            string xy = $"{x} + {y} = {x + y}";
            Console.WriteLine(xy);
            
            Console.WriteLine("№2-c)");
            string s9 = null;
            var b9 = string.IsNullOrEmpty(s9);
            Console.WriteLine(b9);
            
            Console.WriteLine("№2-d)");
            var sb = new StringBuilder("Дизайн эл. и веб-изданий");
            Console.WriteLine(sb);
            var sb1 = sb.Remove(7, 10);
            var sb2 = sb1.Insert(0, "'");
            sb2 = sb1.Append("'");
            Console.WriteLine(sb2);
            
        }
    }
}