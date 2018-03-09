using System;

namespace Convert_a_string_to_an_array
{
    // https://www.codewars.com/kata/57e76bc428d6fbc2d500036d
    // Write a function to split a string and convert it into an array of words.

    // e.g.
    // StringToArray("Robin Singh") => ["Robin", "Singh"]
    // StringToArray("I love arrays they are my favorite") => ["I", "love", "arrays", "they", "are", "my", "favorite"]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", StringToArray("I love arrays they are my favorite")));
        }

        // solution
        public static string[] StringToArray(string str)
        {
            return str.Split();
        }
    }
}
