using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{ 
    class Singleton
    {
        private static Singleton instance = null;
        public static Singleton Instantiate()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        
        public void GetDetails(string msg)
        {
            Console.WriteLine($"Hello {msg}");
        }
    }
    class Program46
    {
        static void Main(string[] args)
        {
            Singleton o1 = Singleton.Instantiate();
            o1.GetDetails("From Training");
            Singleton o2 = Singleton.Instantiate();
            o2.GetDetails("From Development");
        }
    }
}
/*
Singleton pattern,  fall under Creational Pattern categories
This feature used to instantiate object once in the application (Restrict client to create an object) 
There are situations in a project that only one instance of object to be created and shared between different parties.
First time when object is accessed the copy created; later this copy will be used.
Services with business logic are implemented in singleton pattern.
Session object is a singleton
Behave like a Global Object for the Project
Steps to create Singleton:
    Define a private constructor ( so than object cannot be created)
    Define the instance into static 
    Methods can be static or non static
*/