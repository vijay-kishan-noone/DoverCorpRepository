using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum ParkingType
    {
        TwoWheeler, FourWheeler
    }
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("Object is instantiated");
        }
    }
    class ParkingSystem
    {
        private ParkingType type;
        private int capacity, amount, price, count;

        public ParkingSystem(ParkingType type, int count)
        {
            if(type == ParkingType.TwoWheeler)
            {
                capacity = 150;
                price = 20;
            }
            else if(type == ParkingType.FourWheeler)
            {
                capacity = 40;
                price = 40;
            }
            this.type = type;
            this.count = count;
            this.amount = this.count * this.price;
        }
        public void GetDetails()
        {
            Console.WriteLine($"The type is {this.type.ToString()}," +
                $" Capacity is {this.capacity}, Count is {this.count}, Amount is {this.amount}," +
                $" Price is {this.price}");
        }
    }
    class Program25
    {
        static void Main(string[] args)
        {
            ConstructorDemo a = new ConstructorDemo();
            ParkingSystem tw = new ParkingSystem(ParkingType.TwoWheeler, 200);
            tw.GetDetails();
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