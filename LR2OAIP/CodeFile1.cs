using System;
using System.IO;

namespace LR2OAIP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool console = true;
            while (console)
            {
                // Вариант 31
                Console.WriteLine("Файл ввода данных input находится в LR2OAIP/LR2OAIP/bin/Debug");
                Console.WriteLine("Файл вывода данных output находится в LR2OAIP/LR2OAIP/bin/Debug");
                Console.WriteLine();
                TextWriter save_out = Console.Out;
                TextReader save_in = Console.In;
                var new_out = new StreamWriter(@"output.txt");
                var new_in = new StreamReader(@"input.txt");
                Console.SetOut(new_out);
                Console.SetIn(new_in);
                double a, b, c, d, e, s, k;
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = Convert.ToDouble(Console.ReadLine());
                e = Convert.ToDouble(Console.ReadLine());
                if ((a * a - c) <= 0)
                {
                    Console.WriteLine("ERROR");
                }
                else if ((c * c - a) < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    s = ((Math.Sqrt(c * c - a)) / (Math.Sqrt(a * a - c)));
                    Console.WriteLine(String.Format("Переменная S: {0:0.000}", s));
                }
                if (e - c < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else if (b * b - Math.Sqrt(e - c) < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else if (d * d - Math.Sqrt(b * b - Math.Sqrt(e - c)) < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    k = (Math.Sqrt(d * d - Math.Sqrt(b * b - Math.Sqrt(e - c))));
                    Console.WriteLine(String.Format("Переменная K: {0:0.000}", k));
                }
                Console.SetOut(save_out); new_out.Close();
                Console.SetIn(save_in); new_in.Close();

                Console.Write("Выйти из консоли? (y/n): ");
                char quit = Convert.ToChar(Console.ReadLine());
                if (quit == 'y')
                {
                    console = false;
                    break;
                }
                else if (quit == 'n')
                {
                    console = true;
                }
            }
        }
    }
}