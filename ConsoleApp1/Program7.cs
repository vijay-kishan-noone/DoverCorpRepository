using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program7
    {
        static void Main(string[] args)
        {
            var v1 = 100;
            Console.WriteLine(v1.GetType());
            var v2 = 2.3;
            Console.WriteLine(v2.GetType());
            var v3 = true;
            Console.WriteLine(v3.GetType());
            var v4 = 'a';
            Console.WriteLine(v4.GetType());
            var v5 = "hello";
            Console.WriteLine(v5.GetType());
        }
    }
}
/*
 var type used to provide datatype based on value supplied
 variable with var type should not be empty, it assign value at complile time
*/
