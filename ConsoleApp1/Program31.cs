using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IEmail
    {
        void Compose();
        void Inbox();
    }
    class Gmail : IEmail
    {
        public void Compose()
        {
            Console.WriteLine("Code to send mail");
            Console.WriteLine("This feature is used to write mails");
        }
        public void Inbox()
        {
            Console.WriteLine("Code to have Inbox");
            Console.WriteLine("This feature is used to read received mails");
        }
    }
    class Program31
    {
        static void Main(string[] args)
        {
            IEmail i;
            i = new Gmail();
            i.Compose();
            i.Inbox();
        }
    }
}
/*
Interface is one of the type like class in oops programming.
Why do we need interface?
Interface is used as a contract, it contains only method specification (without implementation).
The methods in interface must implement in the derived classes
Points to note:    
    In C#.NET interface name should prefix with I (standard)
    The default access modifier in interface is public
    All the methods in interface are abstract
    Interface should not contains fields
C#.NET Collection API root type is IEnumerable is an Interface
IEnumerator if the return type of GetEnumerator in IEnumerable interface, which implement foreach loop
 */