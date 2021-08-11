using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program16
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int big = 0, small = 0;
            Console.WriteLine("Please enter any 5 elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    big = a[i];
                    small = a[i];
                }
                if (a[i] > big)
                    big = a[i];
                if (a[i] < small)
                    small = a[i];
            }
            Console.WriteLine($"The smallest element is {small}");
            Console.WriteLine($"The biggest element is {big}");
        }
    }
}
