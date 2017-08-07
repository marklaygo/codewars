using System;
using System.Linq;

namespace Simple_Pig_Latin
{
    // https://www.codewars.com/kata/520b9d2ad5c005041100000f

    // Move the first letter of each word to the end of it, then add 'ay' to the end of the word.

    // Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
        }

        // solution
        static string PigIt(string str)
        {
            return String.Join(" ", str.Split().Select(x => x.Substring(1) + x[0] + "ay"));
        }
    }
}