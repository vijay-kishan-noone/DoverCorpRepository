using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program36
    {
        static void Main(string[] args)
        {
            Hashtable items = new Hashtable(); // Key Value Paired Collection
            items.Add(1, "Vijay");
            items.Add(2, "Kishan");
            items.Add(3, "Dover Employee?");
            items.Add(4, true);

            Console.WriteLine("Please Enter a key");
            int key = Convert.ToInt32(Console.ReadLine());

            if(items.Contains(key))
                Console.WriteLine(items[key]);
            else
                Console.WriteLine("Key Doesn't exists...");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (DictionaryEntry item in items) //doesn't follow any order
            {
                Console.WriteLine($"Key is {item.Key} and Value is {item.Value}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            SortedList s = new SortedList(items);
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (DictionaryEntry item in s) //It follows order
            {
                Console.WriteLine($"Key is {item.Key} and Value is {item.Value}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }
    }
}
