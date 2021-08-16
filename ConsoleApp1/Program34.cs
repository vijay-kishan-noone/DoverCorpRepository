using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Teacher
    {
        private int id;
        private string name;
        private string classandsection;

        public string Classandsection
        {
            get { return classandsection; }
            set { classandsection = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
    class Program34
    {
        public static void FileHandling()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "data.txt";
            if (File.Exists(filename))
                Console.WriteLine("File already exists.");
            else
                Console.WriteLine("File doesn't exists, creating new one.");
            using (StreamWriter wrt = File.CreateText(filename))
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
        public static void Store()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "temp.txt";
            if (File.Exists(filename))
                Console.WriteLine("File already exists.");
            else
                Console.WriteLine("File doesn't exists, creating new one.");

        }
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Do you want to 1.Store Data 2.Update Data 3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Store();
                        break;
                    //case 2: Update();
                    //    break;
                    case 3: flag = false;
                        break;
                    default: Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
}
