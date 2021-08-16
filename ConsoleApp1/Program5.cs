using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lmr and pmr");
            int lmr = Convert.ToInt32(Console.ReadLine());
            int pmr = Convert.ToInt32(Console.ReadLine());
            int bu = pmr - lmr;
            double ur = 0;

            if (bu < 150)
                ur = 1.75;
            else if (bu < 375)
                ur = 3.25;
            else if (bu < 500)
                ur = 5;
            else
                ur = 6.5;
            Console.WriteLine("Total amount is "+(bu*ur));
        }
    }
}
