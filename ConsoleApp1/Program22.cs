using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program22
    {
        static void Main(string[] args)
        {
            int ?a = null; //This is how we declare variables that can be null
            if(a is null)
                Console.WriteLine("The given vairable is null");
            else
                Console.WriteLine($"The value is {a}");
            string name = string.Empty;
            if(string.IsNullOrEmpty(name))
                Console.WriteLine("The given vairable is null");
            else
                Console.WriteLine($"The value is {name}");
        }
    }
}
/*
 * nullbale types: used to have empty value into a variable
 * by prefix ? to the variable
 * int ?n=null;
 * 
 * To compare
 * if( n is null)
 *  statement
 */
