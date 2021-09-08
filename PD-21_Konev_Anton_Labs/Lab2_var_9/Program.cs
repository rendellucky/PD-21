using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, k, result;
            result = 1;
            Console.Write("n= ");
            n = Convert.ToDouble(Console.ReadLine());
            k = n * n;
            for (double i = k; i < n * k; i++)
            {
                result = result * (Math.Pow(i, 2) - (Math.Pow(-1, Math.Pow(i, 2) + 1)) * i) / (Math.Pow(i, 2) + 2);
            }
            Console.WriteLine("result= " + result);
        }
    }
}
