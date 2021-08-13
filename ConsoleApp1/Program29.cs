using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmpBaseClass
    {
        protected int id,holiday;
        protected string ename,empType;
        public EmpBaseClass(int id, string ename)
        {
            this.id = id;
            this.ename = ename;
        }
        public void GetDetails()
        {
            Console.WriteLine($"ID is {id}, Name is {ename}, Employee Type is {empType}, " +
                $"Holidays is {holiday}");
        }
    }
    class PartTimeEmployee : EmpBaseClass
    {
        public PartTimeEmployee(int id,string ename) : base(id, ename)
        {
            this.empType = "Part Time";
            this.holiday = 1;
        }
    }
    class FullTimeEmployee : EmpBaseClass
    {
        public FullTimeEmployee(int id, string ename): base(id, ename)
        {
            this.empType = "Full Time";
            this.holiday = 10;
        }
    }
    class Program29
    {
        static void Main(string[] args)
        {
            PartTimeEmployee p = new PartTimeEmployee(101, "Vijay");
            FullTimeEmployee f = new FullTimeEmployee(102, "Kishan");
            p.GetDetails();
            f.GetDetails();
        }
    }
}
