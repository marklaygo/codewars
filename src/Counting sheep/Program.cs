﻿using System;
using System.Linq;

namespace Counting_sheep
{
    // https://www.codewars.com/kata/54edbc7200b811e956000556
    // Consider an array of sheep where some sheep may be missing from their place.
    // We need a function that counts the number of sheep present in the array (true means present).

    // For example,
    // [true, true, true, false,
    // true, true, true, true,
    // true, false, true, false,
    // true, false, false, true,
    // true, true, true, true,
    // false, false, true, true]
    // The correct answer would be 17.

    //Hint: Don't forget to check for bad values like null/undefined
    class Program
    {
        static void Main(string[] args)
        {
            bool[] sheeps = new bool[]
            {
                true, true, true, false,
                true, true, true, true,
                true, false, true, false,
                true, false, false, true,
                true, true, true, true,
                false, false, true, true
            };

            Console.WriteLine(CountSheeps(sheeps));
        }

        // solution
        static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(x => x == true);
        }
    }
}