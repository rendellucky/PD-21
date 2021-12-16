using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Reverse(int[] arr, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void ReverseRefOut(ref int[] arr, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            //1.Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
            /*
               int n, m;
               Console.Write("n= ");
               n = Convert.ToInt32(Console.ReadLine());
               m = 0;
               while(n>0)
               {
                   m = m * 10 + n % 10;
                   n /= 10;
               }
               Console.WriteLine("m= " + m);*/
            //2.	Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
            /* string str;
            Console.Write("word= ");
            str = Console.ReadLine();
            for(int i=str.Length-1;i>=0;i--)
            {
                Console.Write(str[i]);
            }*/
            //3.Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456->321.654)
            /*Console.WriteLine("Enter digit");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { '.' });
            int a;
            int b;
            a = Convert.ToInt32(words[0]);
            b = Convert.ToInt32(words[1]);
            int reversedA = 0;
            int reversedB = 0;
            while (a > 0)
            {
                reversedA = reversedA * 10 + a % 10;
                a /= 10;
            }
            while (b > 0)
            {
                reversedB = reversedB * 10 + b % 10;
                b /= 10;
            }
            Console.WriteLine("Reversed digit: " + reversedA + "." + reversedB);
            */
            //4.	Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
            /*
            int n = 6;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter: " + (i + 1) + " digit: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine();
            Console.WriteLine("Reversing");
            Console.WriteLine();
            Reverse(arr, n);
            //5.	Виконати пункт 4 з використанням ключових слів ref i out
            ReverseRefOut(ref arr, n);
            */
        }
    }

}