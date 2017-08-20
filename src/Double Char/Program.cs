using System;
using System.Linq;

namespace Double_Char
{
    // https://www.codewars.com/kata/56b1f01c247c01db92000076
    //Given a string, you have to return a string in which each character(case-sensitive) is repeated once.

    //DoubleChar("String") == "SSttrriinngg"
    //DoubleChar("Hello World") == "HHeelllloo  WWoorrlldd"
    //DoubleChar("1234!_ ") == "11223344!!__  "
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("String"));
        }

        // solution
        static string DoubleChar(string s)
        {
            return String.Concat(s.Select(x => new string(x, 2)));
        }
    }
}
