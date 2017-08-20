using System;
using System.Linq;

namespace Count_by_X
{
    // https://www.codewars.com/kata/5513795bd3fafb56c200049e
    // Create a function with two arguments that will return a list of length(n) with multiples of(x).
    // Assume both the given number and the number of times to count will be positive numbers greater than 0.

    // Examples:
    // Kata.CountBy(1,10) // should return new int[] {1,2,3,4,5,6,7,8,9,10}
    // Kata.CountBy(2,5) // should return new int[] {2,4,6,8,10}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', CountBy(1, 10)));
        }

        // solution
        static int[] CountBy(int x, int n)
        {
            return Enumerable.Range(1, n).Select(a => a * x).ToArray();
        }
    }
}
