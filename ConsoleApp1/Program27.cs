using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BaseClass
    {
        private int a =1; //accessible within the class
        protected int b=2; //accessible within and dreived class
        public int c=3; //accesssible every where
        public void Display()
        {
            Console.WriteLine($"a is {a}, b is {b}, c is {c}");
        }
    }
    class DerivedClass :BaseClass
    {
        public void DisplayDerived()
        {
            // 'a' is not accessible here
            Console.WriteLine($"b is {b}, c is {c} ");
        }
    }
    class Program27
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            DerivedClass d = new DerivedClass();
            b.Display();
           // d.Display(); 
            d.DisplayDerived();
        }
    }
}
