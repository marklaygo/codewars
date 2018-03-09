using System;
using System.Linq;

namespace Enumerable_Magic_2___True_for_Any
{
    // https://www.codewars.com/kata/54598e89cbae2ac001001135
    // Create an any? (JS: any) function that accepts an array and a block(JS: function),
    // and returns true if the block(/function) returns true for any item in the array.
    // If the array is empty, the function should return false.
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 0, 1, 2, 3, 5, 8, 13 };

            Console.WriteLine(Any(list, v => v % 2 == 0));
        }

        // solution
        public static bool Any(int[] arr, Func<int, bool> fun)
        {
            return arr.Any(fun);
        }
    }
}
