using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int? n = null;
            try
            {
                //This block is used to place statements which may provide exceptions
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                // This block is used to handle exception
                Console.WriteLine("Input type not valid " + ex.Message);
                n = 0;
            }
            catch (Exception ex)
            {
                //This block is used to handle exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                //This block process even when an exception is raised
                Console.WriteLine($"Square of n is {n * n}");
            }

            //Divide By Zero Exception
            Console.WriteLine("Please enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double res=0;
            try
            {
                 res = a / b; //(double) a/b; doesn't provide exception based on IEEE 754 rules
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("We cannot divide a non-zero number by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception has occured");
            }
            finally
            {
                Console.WriteLine($"The result is {res}\n");
            }

            //Index Out Of Range Exception
            int[] x = { 1, 2, 3 };
            try
            {
                Console.WriteLine(x[3]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("You cannot access the array out of range, "+ex.Message);
            }
        }
    }
}
