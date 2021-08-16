using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program8
    {
        static void Main(string[] args)
        {
            Object o = "Dover"; //boxing
            Console.WriteLine(o+" "+o.GetType());

            String name = o.ToString(); //unboxing
            Console.WriteLine(name+" "+name.GetType());

            o = 1000; //boxing
            int num = (int)o; //unboxing
            Console.WriteLine(num+" "+num.GetType());

        }
    }
}
/*
The datatypes used in .NET  are available in a hierachy called CTS (Common Type System)
The root type is Object,all data types like int, char,double etc., derived from Object type

Object type variable allowed to store any type of data called boxing
Boxing refers to assign any type of data into object type
Unboxing refers to dereference the boxed value
*/