using System;

namespace Grasshopper___Basic_Function_Fixer
{
    // https://www.codewars.com/kata/56200d610758762fb0000002

    // Fix the function
    // I created this function to add five to any number that was passed in to it and return the new value.
    // It doesn't throw any errors but it returns the wrong number.

    // Can you help me fix the function?
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddFive(5));
        }

        // solution
        public static int AddFive(int num)
        {
            return num + 5;
        }
    }
}
