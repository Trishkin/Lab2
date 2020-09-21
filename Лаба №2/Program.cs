using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба__2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = 1;
            Console.WriteLine($"{sb}");
            short s = 2;
            Console.WriteLine($"{s}");
            int i = 3;
            Console.WriteLine($"{i}");
            long l = 4;
            Console.WriteLine($"{l}");
            byte b = 5;
            Console.WriteLine($"{b}");
            ushort us = 6;
            Console.WriteLine($"{us}");
            uint ui = 7;
            Console.WriteLine($"{ui}");
            ulong ul = 8;
            Console.WriteLine($"{ul}");
            char ch = 'a';
            Console.WriteLine($"{ch}");
            bool bl = true;
            Console.WriteLine($"{bl}");
            float fl = 9;
            Console.WriteLine($"{fl}");
            double db = 10;
            Console.WriteLine($"{db}");
            decimal dec = 11;
            Console.WriteLine($"{dec}");

            short a1 = 15;
            Console.WriteLine($"First {a1}");
            int b1 = a1;
            Console.WriteLine($"First {b1}");
            long c1 = a1;
            Console.WriteLine($"First {c1}");
            double d1 = a1;
            Console.WriteLine($"First {d1}");
            float e1 = a1;
            Console.WriteLine($"First {e1}");

            int x = 5;
            object j = x;
            int y = (int)j;
            Console.WriteLine($"Second {y}");

            var number = 11;
            Console.Write(number.GetType()); Console.WriteLine();

            Nullable<int> z1 = null;
            int? z2 = null;

            var x1 = 7;
            x1 = 'i';
            Console.WriteLine($"First {x1}");
        }
    }
}
