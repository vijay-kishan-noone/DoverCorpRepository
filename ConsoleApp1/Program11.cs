using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program11
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 11)
            {
                Console.Write($"{i} ");
                i++;
            }

            Console.WriteLine();
            for (i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");


                Console.WriteLine();
                i = 1;
                do
                {
                    Console.Write($"{i} ");
                    i++;

                } while (i < 11);

                Console.WriteLine();
                int[] a = { 1, 2, 3 };
                foreach (int item in a)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
