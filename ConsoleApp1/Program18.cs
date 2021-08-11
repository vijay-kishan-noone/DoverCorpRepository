using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program18
    {
        static void Wishes(string name)
        {
            int hour = DateTime.Now.Hour;
            string wish = string.Empty;
            if (hour < 12)
                wish = "Good Morning";
            else if (hour < 16)
                wish = "Good Afternoon";
            else
                wish = "Good Evening";
            Console.WriteLine($"Hi {name},{wish}");

        }
        static void Display(int a, int b)
        {
            Console.WriteLine($"a={a},b={b}");
        }
        static void Square(ref int a, ref int b) //call by reference, we use "ref" keyword
        {
            a *= a;
            b *= b;
        }
        static void Main(string[] args)
        {
            int a = 20, b = 30;
            Wishes("Vijay");
            Display(a, b);
            Square(ref a, ref b);
            Display(a, b);
        }
    }
}
/*
A method is a function inside a class
A method is a self contained block of statement to perform a task
A method can return a value to the caller
Methdo can be be defined as 
a) static    :    These methods will be called directly
b) regular: These methods will be called using object
*/