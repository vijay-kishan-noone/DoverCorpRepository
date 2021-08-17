using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program42
    {
        //Generally we place this EmpModel Class in separate file
        class EmpModel
        {
            public int Id { get; set; }
            public string Ename { get; set; }
            public string Job { get; set; }
            public int Salary { get; set; }
        }

        // //Generally we place this Class also in separate file
        class EmployeeBO
        {
            public List<EmpModel> employees { get; set; }
            public EmployeeBO()
            {
                employees = new List<EmpModel>()
                {
                    new EmpModel { Id = 1001, Ename = "Kiran", Job = "Trainer", Salary = 30000 },
                    new EmpModel { Id = 1002, Ename = "Vijay", Job = "Developer", Salary = 20000 },
                    new EmpModel { Id = 1003, Ename = "Poonam", Job = "Tester", Salary = 15000 },
                    new EmpModel { Id = 1004, Ename = "Nitish", Job = "Moderator", Salary = 25000 },
                    new EmpModel { Id = 1005, Ename = "Shivani", Job = "HR", Salary = 40000 }
                };
            }
            public List<EmpModel> GetAllEmployees() => employees;
        }
        static void Main(string[] args)
        {
            EmployeeBO context = new EmployeeBO();
            List<EmpModel> employees = context.GetAllEmployees().Take(3).ToList();

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (EmpModel e in employees)
            {
                Console.WriteLine($"{e.Id} {e.Ename} {e.Job} {e.Salary}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*POCO Class: Plain Old CLR Objects
It is a class containing all public properties
These are used to have datasource copy
The object of this class can assign row in database table
List of objects of this class can assign set of datatablerows
*/

/*
            We can use this directly in main method, but it is hard coded.
            EmpModel e1 = new EmpModel { Id = 1001, Ename = "Kiran", Job = "Trainer", Salary = 30000 };
            EmpModel e2 = new EmpModel { Id = 1002, Ename = "Vijay", Job = "Developer", Salary = 20000 };
            EmpModel e3 = new EmpModel { Id = 1003, Ename = "Poonam", Job = "Tester", Salary = 15000 };
            EmpModel e4 = new EmpModel { Id = 1004, Ename = "Nitish", Job = "Moderator", Salary = 25000 };
            //EmpModel e5 = new EmpModel { Id = 1005, Ename = "Shivani", Job = "HR", Salary = 40000 };

            List<EmpModel> employees = new List<EmpModel>();
            employees.Add(e1); employees.Add(e2); employees.Add(e3); employees.Add(e4);
            employees.Add(new EmpModel { Id = 1005, Ename = "Shivani", Job = "HR", Salary = 40000 });

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (EmpModel e in employees)
            {
                Console.WriteLine($"{e.Id} {e.Ename} {e.Job} {e.Salary}");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
*/
