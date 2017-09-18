using System;

namespace Convert_boolean_values_to_strings_Yes_or_No
{
    // https://www.codewars.com/kata/53369039d7ab3ac506000467

    // Given: a boolean value
    // Return: a 'Yes' string for true and a 'No' string for false
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BoolToWord(true));
        }

        // solution
        public static string BoolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }
    }
}
