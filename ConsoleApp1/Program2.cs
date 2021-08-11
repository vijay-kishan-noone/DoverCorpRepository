using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string fullName = Console.ReadLine();
            string firstName = fullName.Substring(0, fullName.IndexOf(" "));
            string lastName = fullName.Substring(fullName.LastIndexOf(" ")+1);
            Console.WriteLine($"First Name is {firstName}");
            Console.WriteLine($"Last Name is {lastName}");
        }
    }
}
/*
Naming convention: While writing programmable code, have to follow naming convetion to identify the code
ClassName, MethodName or any TypeName should be in PascalCase
keywords will be in lower case
containts will be in UPPER CASE
variable names will be camelCaseNotation
*/
