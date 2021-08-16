using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class IntegerExtensionMethods
    {
        public static int Next(this int n)
        {
            return n + 1;
        }
        public static int Square(this int n)
        {
            return n * n;
        }
    }
    public static class StringExtensionMethods
    {
        public static string Upper(this string fullName){
            return fullName.ToUpper();
        }
        public static string FirstName(this string fullName)
        {
            return fullName.Substring(0, fullName.IndexOf(" "));
        }
    }
    class Program39
    {
        static void Main(string[] args)
        {
            int n = 3;
            string name = "vijay kishan";
            Console.WriteLine(n.Next());
            Console.WriteLine(n.Square());
            Console.WriteLine(n.Next().Square());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            name = name.Upper();
            Console.WriteLine(name);
            Console.WriteLine(name.FirstName());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*
Extension method : It is a method, which can be added to existing type to provide topup functionality
Use 'this' keyword in extension method parameter so that it refer to Original class when you invoke it in Program class.
*/