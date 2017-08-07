using System;
using System.Linq;

namespace Beginner_Series_3_Sum_of_Numbers
{
    // https://www.codewars.com/kata/55f2b110f61eb01779000053 
    // Given two integers, which can be positive and negative, find the sum of all the numbers between including them too and return it.If both numbers are equal return a or b.

    // Note! a and b are not ordered!

    // Example: 
    // GetSum(1, 0) == 1   // 1 + 0 = 1
    // GetSum(1, 2) == 3   // 1 + 2 = 3
    // GetSum(0, 1) == 1   // 0 + 1 = 1
    // GetSum(1, 1) == 1   // 1 Since both are same
    // GetSum(-1, 0) == -1 // -1 + 0 = -1
    // GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(-1, 2));
        }

        // solution
        static int GetSum(int a, int b)
        {
            return Enumerable.Range(Math.Min(a, b), Math.Abs(a - b) + 1).Sum();
        }
    }
}