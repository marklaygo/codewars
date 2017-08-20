using System;
using System.Linq;

namespace Find_the_odd_int
{
    // https://www.codewars.com/kata/54da5a58ea159efa38000836
    // Given an array, find the int that appears an odd number of times.
    // There will always be only one integer that appears an odd number of times.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        // solution
        static int find_it(int[] seq)
        {
            return seq.GroupBy(x => x).Where(y => y.Count() % 2 != 0).First().Key;
        }
    }
}
