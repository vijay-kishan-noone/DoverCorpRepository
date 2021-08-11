using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Character : ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Given Character is : {ch}");
            if(ch>64 && ch<91)
                Console.WriteLine($"{ch} is a Capital Letter");
            else if(ch>96 && ch<123)
                Console.WriteLine($"{ch} is a Small Letter");
            else if(ch>47 && ch<58)
                Console.WriteLine($"{ch} is a Digit");
            else
                Console.WriteLine($"{ch} is a Special Character");
        }
    }
}
/*
Character refers to any letter including alphabet, digit, special letters
ASCII value for every letter
A - Z   are 65 to 90
a - z are 97 to 122
0 - 9  are 48 to 57 
 */