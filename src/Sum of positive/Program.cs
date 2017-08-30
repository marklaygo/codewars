using System;
using System.Linq;

namespace Sum_of_positive
{
    // https://www.codewars.com/kata/5715eaedb436cf5606000381
    // You get an array of numbers, return the sum of all of the positives ones.

    // Example [1,-4,7,12] => 1 + 7 + 12 = 20

    // Note: array may be empty, in this case return 0.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PositiveSum(new int[] { 1, -4, 7, 12 }));
        }

        // solution
        static int PositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }
}
