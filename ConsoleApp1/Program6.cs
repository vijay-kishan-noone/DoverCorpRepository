using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int d = Convert.ToInt32(Console.ReadLine());
            switch (d)
            {
                case 1: Console.WriteLine("North");
                        break;
                case 2: Console.WriteLine("East");
                    break;
                case 3: Console.WriteLine("West");
                    break;
                case 4: Console.WriteLine("South");
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
