using System;
using System.Linq;

namespace Reversing_Words_in_a_String
{
    // https://www.codewars.com/kata/57a55c8b72292d057b000594
    // You need to write a function that reverses the words in a given string. 
    // A word can also fit an empty string.
    // If this is not clear enough, here are some examples:

    // As the input may have trailing spaces, you will also need to ignore unneccesary whitespace.

    // Kata.Reverse("Hello World"); // -> "World Hello"
    // Kata.Reverse("Hi There."); // -> "There. Hi"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hello World"));
        }

        // solution
        static string Reverse(string text)
        {
            return String.Join(" ", text.Split().Reverse());
        }
    }
}
