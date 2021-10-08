using System;
using System.Globalization;

namespace ЛР_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1-ТИПЫ");
            
            Console.WriteLine("№1-a)");

            bool a = 2 > 1;
            Console.WriteLine("bool: " + a.ToString());

            byte b = 100;
            Console.WriteLine("byte: "+ b.ToString());
 
            sbyte c = -120;
            Console.WriteLine("sbyte: " + c.ToString());
            
            var readLine_d = Console.ReadLine();
            if (double.TryParse(readLine_d,NumberStyles.Any, NumberFormatInfo.InvariantInfo, out var d))
            {
                Console.WriteLine("double: " + d.ToString());
            }

            decimal e = 23.6m;
            Console.WriteLine("decimal: " + e.ToString());
            
            var readLine_f = Console.ReadLine();
            if (float.TryParse(readLine_f,NumberStyles.Any, NumberFormatInfo.InvariantInfo, out var f))
            {
                Console.WriteLine("float: " + f.ToString());
            }

            int g = 12345;
            Console.WriteLine("int: " + g.ToString());
            
            var readline_h = Console.ReadLine();
            if (uint.TryParse(readline_h, out var h))
            {
                Console.WriteLine("uint: " + h.ToString());
            }

            long i = -123456789;
            Console.WriteLine("long: " + i.ToString());

            ulong j = 123456789;
            Console.WriteLine("ulong: " + j.ToString());

            short k = -1234;
            Console.WriteLine("short: " + k.ToString());

            ushort l = 1234;
            Console.WriteLine("ushort: " + l.ToString());
            
            Console.WriteLine("№1-b)");
            Console.WriteLine("Неявные приведения:");

            int int_c = c;
            Console.WriteLine(int_c);
            long long_k = k;
            Console.WriteLine(long_k);
            double double_g = g;
            Console.WriteLine(double_g);
            ulong ulong_h = h;
            Console.WriteLine(ulong_h);
            float float_j = j;
            Console.WriteLine(float_j);
            
            Console.WriteLine("Явные приведения:");

            byte bb;
            bb = (byte) b;
            Console.WriteLine(bb);
            short gg;
            gg = (short) g;
            Console.WriteLine(gg);
            long ll;
            ll = (long) l;
            Console.WriteLine(ll);
            int dd;
            dd = (int) d;
            Console.WriteLine(dd);
            decimal ff;
            ff = (decimal) f;
            Console.WriteLine(ff);
            
            double dConvert = 49.2;
            string dString = Convert.ToString(dConvert);
            Console.WriteLine(dString);
            
            Console.WriteLine("№1-c)");
            int n = 345;
            object upak = n;
            int rpak = (int) n;
            Console.WriteLine("Результат распаковки: " + n);
            
            Console.WriteLine("№1-d)");
            var t = "dustman";
            Console.WriteLine("Тип переменной: " + t.GetType());
            
            Console.WriteLine("№1-e)");
            int? x = null;
            int? y = x * 25;
            Console.WriteLine("null * numb = ->" + y + "<-");
            
            /*Console.WriteLine("№1-f)");
            var numb = 222;
            numb = bl;*/
        }
    }
}