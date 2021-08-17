using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IShape
    {
        void GetShape();
    }
    class Triangle : IShape
    {
        public void GetShape() => Console.WriteLine("I am a triangle and I have 3 sides");
    }
    class Square : IShape
    {
        public void GetShape() => Console.WriteLine("I am a Square and I have 4 equal sides");
    }
    class Rectangle : IShape
    {
        public void GetShape() => Console.WriteLine("I have a rectangle and U have 4 sides but not equal");
    }
    class Factory
    {
        public static IShape Initialize(Shape shape)
        {
            IShape type = null;
            if (shape == Shape.Rectangle)
                type = new Rectangle();
            else if (shape == Shape.Square)
                type = new Square();
            else if (shape == Shape.Triangle)
                type = new Triangle();
            return type;
        }
    }
    enum Shape
    {
        Square, Rectangle, Triangle
    }
    class Program47
    {
        static void Main(string[] args)
        {
            Console.Write("Enter choice [1: Triangle /2: Rectangle /3: Square]: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            Shape shape = Shape.Square;
            if (ch == 1) shape = Shape.Triangle;
            else if (ch == 2) shape = Shape.Rectangle;
            else if (ch == 3) shape = Shape.Square;
            IShape shape1 = Factory.Initialize(shape);
            shape1.GetShape();
        }
    }
}
/*
In Factory pattern, we create object without exposing the creation logic to the client and 
refer to newly created object using a common interface.
*/