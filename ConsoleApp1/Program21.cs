using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program21
    {
        static void Display()
        {
            Console.WriteLine("Hello!");
        }
        static void Display(string name) //Method Overloading : Defining multiple methods with same name
        {
            Console.WriteLine($"Hello {name}");
        }
        static void Main(string[] args)
        {
            Display();
            Display("Vijay");
        }
    }
}
