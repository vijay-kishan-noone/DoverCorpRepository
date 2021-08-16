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
            //string filename = @"e:\data.txt" 
            //string dir = Directory.GetCurrentDirectory();
            //string filename = dir + "data.txt";
            //if(File.Exists(filename))
            //    Console.WriteLine("File already exists.");
            //else
            //    Console.WriteLine("File doesn't exists, creating new one.");
            //using(StreamWriter wrt = File.CreateText(filename))
            //{
            //    wrt.WriteLine("This is line one");
            //    wrt.WriteLine("This is line two");
            //    wrt.WriteLine("This is line three");
            //}
            //Console.WriteLine("File Created");
            //string[] lines = File.ReadAllLines(filename);
            //foreach (string s in lines)
            //{
            //    Console.WriteLine(s);
            //}
            //string text = File.ReadAllText(filename);
            //Console.WriteLine(text);
            //File.Delete(filename);
            //Console.WriteLine($"{filename} file deleted succesfully");

            //creating file using filestream
            string fname = @"C:\Users\11035974\source\repos\myfile.txt";
            File.CreateText(fname);
            FileStream fs = new FileStream(fname, FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello World");
            sw.Close();
        }
        static void Main(string[] args)
        {
            FileHandling();
        }
    }
}
/*
IO stands for Input and Output
.NET provided an API containing built in classes to handle a files,  namespace is System.IO
File Handling:    This is the feature used to handle files like
Write data, read data, delete file, edit file content, etc.,
To create Object:
StreamWriter obj = new StreamWrite("filename");
Note: The above system will create a new file, overwrite if file already exist
StreamWriter obj = new StreamWrite("filename",true);
By providing true as second parameter, the data will into the content
 */
/*
StreamReader object, contains methods used to read content from the existing file.
string fpath = @"e:\myfile1.txt";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fpath);
                string fileContent = sr.ReadToEnd();
                Console.WriteLine(fileContent);
            }
            catch ( FileNotFoundException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
                Console.WriteLine($"{fpath} not exist...");
            }
            sr.Close();
 */