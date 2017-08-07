using System;

namespace Find_the_missing_letter
{
    // https://www.codewars.com/kata/5839edaa6754d6fec10000a2
    // # Find the missing letter

    // Write a method that takes an array of consecutive(increasing) letters as input and that returns the missing letter in the array.

    // You will always get an valid array. And it will be always exactly one letter be missing.
    // The length of the array will always be at least 2.

    // The array will always contain letters in only one case.

    //   Example:

    // ['a','b','c','d','f'] -> 'e'
    // ['O','Q','R','S'] -> 'P'
    // (Use the English alphabet with 26 letters!)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingLetter(new char[] { 'a', 'b', 'c', 'd', 'f' }));
        }

        // solution
        static char FindMissingLetter(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] > 1)
                {
                    return (char)(array[i] + 1);
                }
            }

            return ' ';
        }
    }
}