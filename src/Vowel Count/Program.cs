using System;
using System.Linq;

namespace Vowel_Count
{
    // https://www.codewars.com/kata/54ff3102c1bad923760001f3
    //Return the number(count) of vowels in the given string.
    //We will consider a, e, i, o, and u as vowels for this Kata.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
        }

        // solution]
        static int GetVowelCount(string str)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            return str.Count(x => vowels.Contains(x));
        }
    }
}
