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
            Console.WriteLine($"Write sbyte = ");
            sbyte sb = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine($"{sb}");
            Console.WriteLine($"Write short = ");
            short s = (short)Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"{s}");
            Console.WriteLine($"Write int = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{i}");
            Console.WriteLine($"Write long = ");
            long l = (long)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{l}");
            Console.WriteLine($"Write byte = ");
            byte b = Convert.ToByte(Console.ReadLine()); ;
            Console.WriteLine($"{b}");
            Console.WriteLine($"Write ushort = ");
            ushort us = (ushort)Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine($"{us}");
            Console.WriteLine($"Write uint = ");
            uint ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"{ui}");
            Console.WriteLine($"Write ulong = ");
            ulong ul = (ulong)Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine($"{ul}");
            Console.WriteLine($"Write char = ");
            char ch = Console.ReadLine()[0];
            Console.WriteLine($"{ch}");
            Console.WriteLine($"Write bool t or f = ");
            char ch1 = Console.ReadLine()[0];
            bool bl ;
            if (ch1 == 't')
            {
                bl = true;
                Console.WriteLine(bl);
            }
            else if (ch1 == 'f')
            {
                bl = false;
                Console.WriteLine(bl);
            }
            else Console.WriteLine($"I don't known what is it ");
            Console.WriteLine($"Write float = ");
            float fl = (float)Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine($"{fl}");
            Console.WriteLine($"Write double = ");
            double db = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine($"{db}");
            Console.WriteLine($"Write decimal = ");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
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
            decimal f1 = a1;
            Console.WriteLine($"First {f1}");
            short a2 = 15;
            Console.WriteLine($"First {a2}");
            int b2 = (int)a2;
            Console.WriteLine($"First {b2}");
            long c2 = (long)a2;
            Console.WriteLine($"First {c2}");
            double d3 = (double)a2;
            Console.WriteLine($"First {d3}");
            float e2 = (float)a2;
            Console.WriteLine($"First {e2}");
            decimal f2 = (decimal)a2;
            Console.WriteLine($"First {f2}");
            double d2 = Convert.ToDouble(a1);
            Console.WriteLine($"First {d2}");

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

            String path, path1, path2;
            path = "C:\\Windows\\regedit.exe"; //верно
            path1 = @"C:\Windows\regedit.exe"; //верно, наиболее предпочтительно
            path2 = "C:/Windows/regedit.exe"; //верно
            int tru = path.CompareTo(path1);
            Console.WriteLine($"First {tru}");

            string newpath = String.Concat(path, path1, path2);
            Console.WriteLine($"{newpath}");

            newpath = String.Copy(path);
            Console.WriteLine($"{newpath}");

            newpath = path.Substring(4, 2);
            Console.WriteLine($"{newpath}");

            string[] words = path2.Split('/');
            Console.WriteLine($"{words[0]}");
            Console.WriteLine($"{words[1]}");
            Console.WriteLine($"{words[2]}");

            newpath = path.Insert(3, "MyName\\");
            Console.WriteLine($"It's something new - {newpath}");

            newpath = newpath.Remove(3, 7);
            Console.WriteLine(newpath);

            string s1 = "";
            string s2 = null;
            if (string.IsNullOrEmpty(s1))
                Console.WriteLine($"first {newpath}");
            if (string.IsNullOrEmpty(s2))
                Console.WriteLine($"second {newpath}");
            if (string.IsNullOrEmpty(newpath))
                Console.WriteLine($"ops, something wrong");
            tru = newpath.CompareTo(s2);
            newpath = String.Concat(s1, s2);

            StringBuilder sbuild = new StringBuilder("Hello", 30);
            Console.WriteLine(sbuild);
            sbuild.Remove(0, 3);
            Console.WriteLine(sbuild);
            sbuild.Insert(0, "A");
            Console.WriteLine(sbuild);
            sbuild.Append(new char[] { 'h', 'a' });
            Console.WriteLine(sbuild);

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 },{ 7,8,9} };
            for (int i0 = 0; i0 < 3; i0++)
            {
                for (int i1 = 0; i1 < 3; i1++)
                    Console.Write("\t" + matrix[i0, i1]);
                Console.WriteLine();
            }

            string[] masstr = { "Hello", "my", "little", "world" };
            foreach (var str in masstr)
                Console.Write("\t" + str);
            Console.WriteLine();
            Console.WriteLine(masstr.Length);
            int choice = -1;
            while (choice < 0 || choice > 3)
            {
                Console.Write("Введите номер позиции для замены (0-3):");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 0 || choice > 3)
                    Console.WriteLine("Пожалуйста, введите корректно значение.");
            }
            Console.Write("Введите ваш текст:");
            masstr[choice] = Console.ReadLine();
            foreach (var str in masstr)
                Console.Write("\t" + str);
            Console.WriteLine();

            Double[][] masfl = { new Double[2], new Double[3], new Double[4]};
            Console.WriteLine("Введите ваши значения вещественных чисел (9 раз)");
            int i2 = 2;
            int index =1;
            for (int i0 = 0; i0 < 3; i0++)
            { 
                for (int i1 = 0; i1 < i2; i1++)
                {
                    Console.Write("\t" + index + ":") ;
                    masfl[i0][i1] = Convert.ToDouble(Console.ReadLine());
                    index++;
                }
                i2++;
                Console.WriteLine();
            }
            foreach (double[] masfl0 in masfl)
            {
                foreach (double masfl1 in masfl0)
                    Console.Write("\t" + masfl1);
                Console.WriteLine();
            }

            var varmas = new[] { 1, 2, 3 };
            var varstr = "help";
            Console.WriteLine();
            foreach (double masfl1 in varmas)
                Console.Write("\t" + masfl1);
            Console.WriteLine();
            Console.WriteLine(varstr);

            ValueTuple<int, string , char, string, ulong> Tuple = (18, "Dima", 'B', "Kulikov", 1218);
            Console.WriteLine(Tuple);
            Console.WriteLine("\t" + Tuple.Item1 + "\t" + Tuple.Item3 + "\t" + Tuple.Item4);
            var (first, sec, _, breh, _) = Tuple;
            Console.WriteLine(first);
            Console.WriteLine(breh);
            (int firi, _, char secc, string thirs, _) = Tuple;
            (var firv, var carv, _, string srinv, _) = Tuple;
            ValueTuple<int, string, char, string, ulong> Tuple2 = Tuple;
            int res = Tuple.CompareTo(Tuple2);
            Console.WriteLine(res);

            Console.WriteLine(LocalFunc(new int[] { 1, 2, 3, 4 }, "Boris"));
            (int, int, int, char) LocalFunc(int[] x12, string str) {
                ValueTuple<int, int, int, char> Tuple3 = (x12.Max(), x12.Min(), x12.Sum(),str[0]);
                return Tuple3;
            };

            LocalFunc1();
            int LocalFunc1 ()
            {
                checked
                {
                    int chec = 2147483647;
                    //Console.WriteLine(chec+2);            //Переполнение
                }
                return 0;
            };
            LocalFunc2();
            int LocalFunc2() 
            {
                unchecked
                {
                    int chec = 2147483647;
                    Console.WriteLine(chec+2);
                }
                return 0;
            }
            Console.ReadKey();
        }
    }
}
