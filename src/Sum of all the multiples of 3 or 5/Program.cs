using System;
using System.Linq;

namespace Sum_of_all_the_multiples_of_3_or_5
{
    // https://www.codewars.com/kata/57f36495c0bb25ecf50000e7
    // Your task is to write function findSum.
    // Upto and including n, this function will return the sum of all multiples of 3 and 5.

    // For example:
    // findSum(5) should return 8 (3 + 5)
    // findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSum(5));
        }

        // solution
        public static int FindSum(int n)
        {
            return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
