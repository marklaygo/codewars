using System;

namespace Remove_exclamation_marks
{
    // https://www.codewars.com/kata/57a0885cbb9944e24c00008e
    // Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveExclamationMarks("Hello World!"));
        }

        // solution
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", "");
        }
    }
}
