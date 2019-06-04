using Ext.Net;
using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // insert the value of variables a, b, h
            Console.Write(" insert start value of x: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("insert finish value of x: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("insert the value of increment of x: ");
            double h = Convert.ToDouble(Console.ReadLine());
            while (a <= b);
            {
                double function = Math.Pow((a - 0.1) * Math.Sqrt(a) - ((a + 1.0 / 3.0) / a)), 1.0 / 3)*Math.Cos(2.5 * a);
                Console.WriteLine(" when x = " + a + " f(x)= " + function);
                a += h;
            }
            Console.ReadLine();
        }
    }
}
