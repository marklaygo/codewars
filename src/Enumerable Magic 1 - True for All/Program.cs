using System;
using System.Linq;

namespace Enumerable_Magic_1___True_for_All
{
    // https://www.codewars.com/kata/54598d1fcbae2ae05200112c
    // Create a method all which takes an array and a predicate(function pointer),
    // and returns true if the predicate returns true for every element in the array.
    // Otherwise, it should return false. If the array is empty,
    // it should return true, since technically nothing failed the test.
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 2, 4, 6, 10 };

            Console.WriteLine(All(list, v => v % 2 == 0));
        }

        // solution
        public static bool All(int[] arr, Func<int, bool> fun)
        {
            return arr.All(fun);
        }
    }
}
