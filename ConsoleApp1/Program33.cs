using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program33
    {
        public static void FileHandling()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "data.txt";
            if(File.Exists(filename))
                Console.WriteLine("File already exists.");
            else
                Console.WriteLine("File doesn't exists, creating new one.");
            using(StreamWriter wrt = File.CreateText(filename))
            {
                wrt.WriteLine("This is line one");
                wrt.WriteLine("This is line two");
                wrt.WriteLine("This is line three");
            }
            Console.WriteLine("File Created");
            string[] lines = File.ReadAllLines(filename);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
            string text = File.ReadAllText(filename);
            Console.WriteLine(text);
            File.Delete(filename);
            Console.WriteLine($"{filename} file deleted succesfully");
        }
        static void Main(string[] args)
        {
            FileHandling();
        }
    }
}
