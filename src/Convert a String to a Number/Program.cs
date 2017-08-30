using System;

namespace Convert_a_String_to_a_Number
{
    // https://www.codewars.com/kata/544675c6f971f7399a000e79

    // We need a function that can transform a string into a number. 
    // What ways of achieving this do you know?

    // Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.

    // Examples
    // StringToNumber("1234") == 1234
    // StringToNumber("605") == 605
    // StringToNumber("1405") == 1405
    // StringToNumber("-7") == -7
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringToNumber("1234"));
        }

        // solution
        static int StringToNumber(String str)
        {
            return Convert.ToInt32(str);
        }
    }
}
