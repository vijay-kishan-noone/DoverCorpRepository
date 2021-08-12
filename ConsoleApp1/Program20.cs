using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program20
    {
        static void DisplayNames(string batchCode,params string[] names)
        {
            Console.WriteLine($"Batch Code is: {batchCode}");
            Console.WriteLine("Give names are:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DisplayNames("GET-July","Dover", "Corporation");
            DisplayNames("Emp-Id","Software","Development", "Engineer");
        }
    }
}
/*
 params type:   Allow to have differnt number of arguments to a function
Can have only one params type as argument
can have another variable before to params also
*/
