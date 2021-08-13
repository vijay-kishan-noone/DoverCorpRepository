using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("This is the Parent Class");
        }
    }
    class IntermediateClass : ParentClass
    {
        public IntermediateClass()
        {
            Console.WriteLine("This is the Intermediate Class");
        }
    }
    class ChildClass : IntermediateClass
    {
        public ChildClass()
        {
            Console.WriteLine("This is the Child Class");
        }
    }
    class Program28
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
        }
    }
}
