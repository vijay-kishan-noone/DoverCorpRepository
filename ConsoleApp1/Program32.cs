using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    partial class MyClass
    {
        public void Display1()
        {
            Console.WriteLine("Hello from the Display1");
        }
    }
    partial class MyClass
    {
        public void Display2()
        {
            Console.WriteLine("Hello from the Display2");
        }
    }
    class Program32
    {
        static void Main(string[] args)
        {
            MyClass o = new MyClass();
            o.Display1();
            o.Display2();
        }
    }
}
