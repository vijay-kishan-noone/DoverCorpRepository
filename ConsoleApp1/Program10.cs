using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());

            int hour = DateTime.Now.Hour;
            if(hour<12)
                Console.WriteLine("Good Morning");
            else if (hour<16)
                Console.WriteLine("Good Afternoon");
            else
                Console.WriteLine("Good Evening");

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower();
            if(day == "sat" || day == "sun")
                Console.WriteLine("Enjoy your weekend");
            else
                Console.WriteLine("Please start working");
        }
    }
}
/*
  DateTime: It is an inbuilt structure, used to get current data and time related values
 */