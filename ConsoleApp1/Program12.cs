using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program12
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine($"{i} {11 - i}");
                Thread.Sleep(1000);
                i++;
            }
            i = 1;
            while (i < 11)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i},");
                }
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i < 11)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i},");
                }
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i < 6)
            {
                Console.Write($"{6 - i},");
                i++;
            }
        }
    }
}
