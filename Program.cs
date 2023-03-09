using System;
using System.Collections.Generic;
using System.Text;

namespace АЙЗЕК
{
    internal class Program
    {
        static double a, b, x, e, d, c;
        static int n = 1;
        static Random rnd = new Random();
        static double f_der(double x)
        {
            return 4*x+1-Math.Sin(2*x);
        }
        static double f_der2(double x)
        {
            return 4-2*Math.Cos(2*x);
        }
        static double chtoto(double x)
        {
            return x - f_der(x) / f_der2(x);
        }
        static double f(double x)
        {
            double f = 2 * x * x + x + Math.Pow(Math.Cos(x), 2);
            return f;
        }
        private static void Main(string[] args)
        {
            a = -1;
            b = 1;
            d = 0.0000001;
            e = 0.000001;
            x = rnd.NextDouble() + rnd.NextDouble()-1;
            c = Int32.MaxValue;
            while (Math.Abs(x - c) >= e)
            {
                c = x;
                x = chtoto(x);
                n++;
            }
            Console.WriteLine("X минимальное: " + Convert.ToString(x));
            Console.WriteLine("Значение функции в этой точке: " + Convert.ToString(f(x)));
            Console.WriteLine("Кол-во итераций " + Convert.ToString(n-1));
            Console.ReadLine();
        }
    }
}