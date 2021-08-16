using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program37
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mangoes", "Grapes" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*
Generic is used to restrict the datatype in collections
*/