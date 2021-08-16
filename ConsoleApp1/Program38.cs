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
            
            Console.WriteLine();
            var query = from item in items select item;
            foreach(var item in query)
                Console.WriteLine(item);
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
