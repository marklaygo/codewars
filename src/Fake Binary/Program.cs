using System;
using System.Linq;

namespace Fake_Binary
{
    // https://www.codewars.com/kata/57eae65a4321032ce000002d
    // Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. 
    // Return the resulting string.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FakeBin("5"));
        }

        // solution
        static string FakeBin(string x)
        {
            return String.Concat(x.Select(y => y < '5' ? "0" : "1"));
        }
    }
}
