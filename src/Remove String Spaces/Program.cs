using System;

namespace Remove_String_Spaces
{
    // https://www.codewars.com/kata/57eae20f5500ad98e50002c5
    // Simple, remove the spaces from the string, then return the resultant string.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoSpace("Hello World!"));
        }

        // solution
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
