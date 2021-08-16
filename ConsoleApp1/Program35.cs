using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program35
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(3); // once remove 3 and see the difference
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");
            a.Add(1);
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");
            a.Add("Vijay");
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");
            a.Add("Kishan");
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");
            a.Add("Dover Employee?");
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");
            a.Add(true);
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");
            a.TrimToSize();
            Console.WriteLine($"Capacity is {a.Capacity} and Count is {a.Count}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/*
 Collection:    A collection is an API, contains inbuilt types of data structures
Each collection type has predefined methods and implementation
Advantages:
    Allow to store any type of data
    Any number of elements
    Define methods to perform operations like insert, delete, update, etc.,
Why collection?
    To overcome limtations of an array
    Array:    It is an abstract data type
    Used to group of similar elements within single identification
Limitations in Array:
    a) Array elements allow only one type of data
    b) Array size is fixed (cannot enhance)
    c) Array contains Length attribute only ( a separate count variable to be maintained)
    d) Operations like insert, delete, etc.,will be done by shifting elements
To overcome the limitation we use data structures
Data structures:
    Are based on dynamic memory allocations
OOPs languages provide inbuilt data structures in the form  Collection
 */
/*
Available collection types:
    ArrayList
    LinkedList
    Hashtable
    SorteList
    etc.,
How a collection object items allow different types of data?
    Collection object type take object as parameter
    Object all any type of data using boxing feature
How a collection object allow unlimited items?
The default Capacity is zero
While adding first element the Capacity incrases to 4
While adding fifth element the Capacity incrases to 8   
While adding ninth element the Capacity incrases to 16
 */