using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum MaritalStatus
    {
        Married, Unmarried, Divorce
    }
    class Program9
    {
        static void Main(string[] args)
        {
            MaritalStatus test = MaritalStatus.Married;
            Console.WriteLine(MaritalStatus.Married);
            if(test == MaritalStatus.Married)
                Console.WriteLine("Please leave by 7pm");
            else if(test == MaritalStatus.Unmarried)
                Console.WriteLine("Please leave by 8pm");
            else if(test == MaritalStatus.Divorce)
                Console.WriteLine("You can leave anytime");
        }
    }
}
/*
enum: enumerated type, used to have set of constants
Example:    Gender, MartialStatus, Color, Direction
 
const used to have constatnt variable, which cannot be changed
const string directorName= "Raj";
Console.WriteLine(directorName);
 */
