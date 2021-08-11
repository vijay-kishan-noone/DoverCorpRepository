using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program19
    {
        static void Initialize(out int a)
        {
            a = 0;
        }
        static void GetRole(string qualification, out string eligibleRole)
        {
            switch (qualification)
            {
                case "B.Tech":
                    eligibleRole = "Programmer";
                    break;
                case "MBA":
                    eligibleRole = "HR";
                    break;
                default:
                    eligibleRole = "Assitant";
                    break;
            }
        }
        static void Main(string[] args)
        {
            int a;  // The reason we are not using ref is ref can't be used for unintialized variables
            Initialize(out a);
            Console.WriteLine(a);
            string qualification = "B.Tech";
            string eligibleRole;
            GetRole(qualification, out eligibleRole);
            Console.WriteLine($"For qualification {qualification}, the eligible role is {eligibleRole}");
        }
    }
/*
  out parameter used to have variable without initializtion and changes will be effect to
   the original commonly used in the case of initialization at definition
*/
}
