using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program15
    {
        static void Main(string[] args)
        {
            int []items; //Array Declaration
            items = new int[5]; //Memory Allocation
            items[0] = 1;
            items[1] = 2;
            items[2] = 3;
            items[3] = 4;
            items[5] = 5;
        }
    }
}
/*
 * Array is a Programming feature, allow to store more than one value within a single identification and programmable. All elements will store in homogeneous order. Arrays are the best place to handle limited number of elements.
Application of an Array:
    Days in a month, Hours in day,     Students in a classroom,  Seats in  bus, etc.,
Points to note:
Array is Abstract class in .NET Collection API
Array declared at compiled time (Stored in Stack Memory)
Arrays are index based collection, accessible using [ ] notation.
First element is accessible using 0 index, last element is accessible using Length-1 as index
Dimensions are accessible using Rank property
Limitations:
               Array variable will store one type of data.    
    Array variable size fixed (cannot enhance).
    Insertion, deletion and sorting, searching of elements in array is big process.
 */
