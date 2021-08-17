using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program38
    {
        static void Main(string[] args)
        {
            //string[] items = new string[] { "plants", "flower", "fruits", "vegetables" };
            List<string> items = new List<string>{"plants", "flower", "fruits", "vegetables" };
            Console.WriteLine(items.First());
            Console.WriteLine(items.Last());
            Console.WriteLine(items.ElementAt(2));
            Console.WriteLine(items.Max());
            Console.WriteLine(items.Min());
            Console.WriteLine();
            foreach (string item in items.Take(2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (string item in items.Skip(2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //var query = from item in items select item;
            //var query = from item in items orderby item select item;
            //var query = from item in items orderby item descending select item;
            //var query = from item in items where name.Length ==5 select item;

            //var query = items.Where(x => x.Length == 6); 
            var query = items.Take(2).Where(x => x.Length == 6); //we use func delegate in Where()
            foreach (var item in query)
                Console.WriteLine(item);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
/*Linq: Language Integrated Query
Line enable us to interact with datasource  with a single syntax 
Data sources like like array, collection, file, database, etc., 
In order to use linq feature we can use following ways
a) Sql like queries
b) Linq like queries
 */
