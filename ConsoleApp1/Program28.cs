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
        public virtual void Display()
        {
            Console.WriteLine("Displaying from Intermediate Class");
        }
    }
    class ChildClass : IntermediateClass
    {
        public ChildClass() : base() //constructor Overriding
        {
            Console.WriteLine("This is the Child Class");
        }
        public override void Display()
        {
            base.Display(); //Invoking base class method from child class
            Console.WriteLine("Displaying from Child Class");
        }
    }
    class Program28
    {
        static void Main(string[] args)
        {
            IntermediateClass i;
            i = new IntermediateClass();
            i.Display();
            i = new ChildClass(); // once remove virtual and override to see difference
            i.Display();

        }
    }
}
/*
 * Virtual method :
 * 
 * When the object declared for base class and memory allocated to derived , 
 * the base class method override even memory refers to child class
 * 
 * To overcome this, prefix virtual to the base class method and override in child class
 * Virtual methods can be overloaded
 */