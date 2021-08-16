using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program40
    {
        static void Main(string[] args)
        {
            Action display = delegate ()
            {
                Console.WriteLine("Hello World!");
            };
            Action<string> wishes = delegate (string name)
            {
                Console.WriteLine($"Hello {name}");
            };
            display();
            wishes("Vijay");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Func<int, int> Square = delegate (int n)
            {
                return n * n;
            };
            Func<int, int> Next = delegate (int n)
             {
                 return n + 1;
             };
            Console.WriteLine(Square(2));
            Console.WriteLine(Next(1000));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
/*
Delegate:    A delegate is a typesafe funcition pointer
The object of delegate can be referred to a function or set of functions
.net provided 3 inbuilt delgates
Action    :    Refers to a function perform a task and without returning value
Func    :    Refers to a function  return a value
Predicate:    Refers to a function return boolean value

Delegate enable us send a function as a parameter to other function
*/