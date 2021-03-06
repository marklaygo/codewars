﻿using System;
using System.Linq;

namespace Scramblies
{
    // https://www.codewars.com/kata/55c04b4cc56a697bb0000048
    // Write function scramble(str1, str2) that returns true 
    // if a portion of str1 characters can be rearranged to match str2,
    // otherwise returns false.

    // For example:
    // str1 is 'rkqodlw' and str2 is 'world' the output should return true.
    // str1 is 'cedewaraaossoqqyt' and str2 is 'codewars' should return true.
    // str1 is 'katas' and str2 is 'steak' should return false.

    // Only lower case letters will be used(a-z). No punctuation or digits will be included.
    // Performance needs to be considered
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("rkqodlw", "world"));
        }

        // solution
        static bool Scramble(string str1, string str2)
        {
            return str2.All(x => str1.Count(y => y == x) >= str2.Count(z => z == x));
        }
    }
}