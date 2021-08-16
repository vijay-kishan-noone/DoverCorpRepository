using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program4
    {
        //Read marks for m,p,c and display the total and average of those marks
        static void Main(string[] args)
        {
            Console.Write("Enter the marks for math : ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks for physics : ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks for chemistry : ");
            int chemistry = Convert.ToInt32(Console.ReadLine());

            int total = math + physics + chemistry;
            double avg = (double)total / 3;
            Console.WriteLine($"Total Marks is {total}");
            Console.WriteLine($"Average is {avg}");
            string grade = string.Empty;

            if (math >34 && physics > 34 && chemistry > 34)
            {
                Console.WriteLine($"You have passed the exams");
                if (avg >= 75)
                    grade = "A";
                else if (avg > 60)
                    grade = "B";
                else
                    grade = "C";
            }
            else
            {
                Console.WriteLine($"You have failed the exams");
                grade = "NA";
            }
            Console.WriteLine($"Grade is {grade}");
        }
    }
}
/*
 
Control structure: Used to control statement execution

if:     used as branching
case:   used for constant expression in the condition
loop:   to iterate statements

relational operators:   >,>=,<,<=,==,!=
logical operators:      && (and),   || (or),    !(not)

*/
