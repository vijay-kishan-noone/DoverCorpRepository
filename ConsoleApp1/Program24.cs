using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Number
    {
        //data members section
        private int num1;

        //member function section
        public void SetNumber(int num1)
        {
            this.num1 = num1;
        }
        public void GetNumber()
        {
            Console.WriteLine($"num1 = {this.num1}");
        }

    }
    class Program24
    {
        static void Main(string[] args)
        {
            Number n1 = new Number();
            n1.SetNumber(100);
            n1.GetNumber();
        }
    }
}
/*
Class:    It is a user defined data type
Object:    Instance of a class
Date member:    Refers to variable inside a class
Member function:    Refers to function inside a class
private:    Access modifier restrict access of member to outside
public:        Acess modifier allow access of member to outside
*/
