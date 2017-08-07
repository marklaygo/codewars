using System;
using System.Linq;

namespace Reversed_Words
{
    // https://www.codewars.com/kata/51c8991dee245d7ddf00000e
    // Complete the solution so that it reverses all of the words within the string passed in.

    // Example:

    // Kata.ReverseWords("The greatest victory is that which requires no battle");
    // should return "battle no requires which that is victory greatest The"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("The greatest victory is that which requires no battle"));
        }

        // solution
        static string ReverseWords(string str)
        {
            return String.Join(" ", str.Split().Reverse());
        }
    }
}