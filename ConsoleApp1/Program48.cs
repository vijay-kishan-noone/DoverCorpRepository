using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IItem
    {
        string Cook();
    }
    class NonVeg : IItem
    {
        private string dish;
        public NonVeg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Non Veg " + dish + " cooked, ready and start eating";
        }
    }
    class Veg : IItem
    {
        private string dish;
        public Veg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Veg " + dish + " cooked, ready and start eating";
        }
    }
    class ExpertCook
    {
        IItem item;
        public ExpertCook(IItem item)
        {
            this.item = item;
        }
        public void StartEating()
        {
            if (this.item == null)
                Console.WriteLine("Dish not available, sorry");
            else
                Console.WriteLine(item.Cook());
        }
    }
    class Program48
    {
        static void Main(string[] args)
        {
            ExpertCook ck1 = new ExpertCook(new NonVeg("Chilli Chicken"));
            ExpertCook ck2 = new ExpertCook(new Veg("French fries"));
            ck1.StartEating();
            ck2.StartEating();
        }
    }
}
/*
DI (Dependency Injection) is a technique whereby one object supplies the dependencies of another object. 
A dependency is an object that can be used (a service).
An injection is the passing of a dependency to a dependent object (a client) that would use it.
In real time the services are injected to a class using DI mechanism
*/
