using System;
using System.Collections.Generic;
using System.Linq;

namespace Filtering_even_numbers
{
    // https://www.codewars.com/kata/566dc566f6ea9a14b500007b
    // Fix the bug in Filtering method
    // The method is supposed to remove even numbers from the list and return a list that contains odd number.

    // However, there is a bug in the method that needs to be resolved.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
            
            Console.WriteLine(string.Join(", ", FilterOddNumber(listOfNumbers)));
        }

        // solution
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            return listOfNumbers.Where(x => x % 2 != 0).ToList();
        }
    }
}
