using System;
using System.Linq;

namespace Grasshopper___Summation
{
    // https://www.codewars.com/kata/55d24f55d7dd296eb9000030
    //Summation

    //Write a program that finds the summation of every number between 1 and num.
    // The number will always be a positive integer greater than 0.

    //For example:
    //summation(2) -> 3
    //1 + 2

    //summation(8) -> 36
    //1 + 2 + 3 + 4 + 5 + 6 + 7 + 8
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(summation(2));
        }

        // solution
        static int summation(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
    }
}