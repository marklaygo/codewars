using System;
using System.Linq;

namespace Stop_gninnipS_My_sdroW
{
    // https://www.codewars.com/kata/5264d2b162488dc400000001
    // Write a function that takes in a string of one or more words, and returns the same string, 
    // but with all five or more letter words reversed(Just like the name of this Kata). 
    // Strings passed in will consist of only letters and spaces.
    // Spaces will be included only when more than one word is present.

    // Examples:
    // spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
    // spinWords( "This is a test") => returns "This is a test" 
    // spinWords( "This is another test" ) => returns "This is rehtona test"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("This is another test"));
        }

        // solution
        static string SpinWords(string sentence)
        {
            var words = sentence.Split();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
            }

            return String.Join(" ", words);
        }
    }
}