using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 124;
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum += num % 10;
                num /= 10;
            }
            if(sum % 2!=0)
            {
                Console.WriteLine("the number is odd");
            }
            else
            {
                Console.WriteLine("the number is even");
            }
        }
    }
}
