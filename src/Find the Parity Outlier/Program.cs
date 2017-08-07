using System;
using System.Linq;

namespace Find_the_Parity_Outlier
{
    // https://www.codewars.com/kata/5526fc09a1bbd946250002dc
    // You are given an array(which will have a length of at least 3, but could be very large) containing integers.
    // The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
    // Write a method that takes the array as an argument and returns N.

    // For example:
    // [2, 4, 0, 100, 4, 11, 2602, 36]
    // Should return: 11

    //[160, 3, 1719, 19, 11, 13, -21]
    //Should return: 160
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Find(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
        }

        // solution
        static int Find(int[] integers)
        {
            return integers.Take(3).Count(x => x % 2 == 0) == 3 ? integers.First(x => x % 2 != 0) : integers.First(x => x % 2 == 0);
        }
    }
}