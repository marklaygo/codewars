using System;
using System.Linq;

namespace Find_the_smallest_integer_in_the_array
{
    // https://www.codewars.com/kata/55a2d7ebe362935a210000b2
    // Given an array of integers your solution should find the smallest integer.

    // For example:
    // Given[34, 15, 88, 2] your solution will return 2
    // Given[34, -345, -1, 100] your solution will return -345

    // You can assume, for the purpose of this kata, that the supplied array will not be empty.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSmallestInt(new int[] { 34, 15, 88, 2 }));
        }

        // solution
        static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }
    }
}
