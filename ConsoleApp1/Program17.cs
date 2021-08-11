using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program17
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 1, 2 },{ 3, 4 } }; //Double Dimensional Array
            //a[0, 0] = 1;
            //a[0, 1] = 2;
            //a[1, 0] = 3;
            //a[1, 1] = 4;
            Console.WriteLine(a[0,1]);
            //Jagged Arrays - Array can contain different number of rows and columns
            int[][] b = new int[2][];
            b[0] = new int[] { 1, 2 };
            b[1] = new int[] { 3, 4, 5 };
            Console.WriteLine("\nJagged Arrays Demonstration\n");
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
