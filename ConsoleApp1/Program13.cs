using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{   
    //Generate Fibonnaci series
    class Program13
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            int c = 0;
            Console.Write($"{a} {b} ");
            int i = 2;
            while (i < 11)
            {
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
                i++;
            }

        }
    }
}
