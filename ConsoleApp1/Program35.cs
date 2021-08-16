using System;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    class Program35
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Console.WriteLine(a.Capacity);
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