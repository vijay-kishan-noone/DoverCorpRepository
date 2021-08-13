using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("Object is instantiated");
        }
    }
    class Program25
    {
        static void Main(string[] args)
        {
            ConstructorDemo a = new ConstructorDemo();
            ConstructorDemo b = new ConstructorDemo();
        }
    }
}
/*
constructor:    This method is used to instantiate data members
This is a special method
a) Exist with same name of the class
b) Invoke implcitly
Scenario:   The initial formalities while joining in company will be done using constructor
*/