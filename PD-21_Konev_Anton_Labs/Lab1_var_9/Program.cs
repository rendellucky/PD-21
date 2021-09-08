using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_var_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, t, s, a;
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("t= ");
            t = Convert.ToDouble(Console.ReadLine());
            v = a / t;
            s = v * t + (a * Math.Pow(t, 2) / 2);
            Console.WriteLine("s= " + s);
        }
    }
}
