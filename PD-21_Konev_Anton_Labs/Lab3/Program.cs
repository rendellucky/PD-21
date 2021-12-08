using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter: " + (i + 1) + " digit: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tmp = arr[0];
            Console.WriteLine();
            for (int i = 0; i < n-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[n-1] = tmp;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
