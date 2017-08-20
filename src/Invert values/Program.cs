using System;
using System.Linq;

namespace Invert_values
{
    // https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad
    // Given a set of numbers, return the additive inverse of each.
    // Each positive becomes negatives, and the negatives become positives.

    // invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
    // invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
    // invert([]) == []
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', InvertValues(new int[] { 1, 2, 3, 4, 5 })));
        }

        // solution
        static int[] InvertValues(int[] input)
        {
            return input.Select(x => -x).ToArray();
        }
    }
}
