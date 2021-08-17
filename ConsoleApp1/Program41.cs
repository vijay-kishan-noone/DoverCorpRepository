using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program41
    {
        static void Main(string[] args)
        {
            Action Display = () => Console.WriteLine("Hello, Good Morning!");
            Display();
            Action<string> Wishes = x => Console.WriteLine($"Hello, {x}");
            Wishes("Vijay");

            Func <int,int> Square = (int x) => x * x;
            Console.WriteLine(Square(2));

            Func<int, int, int> Addition = (int a, int b) => a + b;
            Console.WriteLine(Addition(5,3));

            Func<string, int> Length = (string x) => x.Length;
            Console.WriteLine(Length("Vijay"));
            
            //Func<LambdaExpression,return type of that Lambda Expression,parameters>
            Func<Func<int, int, int>, int, int, int> Caluclate = (cal, a, b) => cal(a, b);
            Console.WriteLine(Caluclate(Addition,10,20));
            Console.WriteLine(Caluclate((a,b)=>a-b,20,10)); //we can also provide definition dynamically
        }
    }
}
/*
Lambda Expression : It is a simple and a short function definition which can be provided
                    as an argument.
Advantages : Instant implementation

Will use inbuilt delegates (Action, Func, Parameters) for demo purposes
These Lambda Expression called as arrow functions in javascript
*/