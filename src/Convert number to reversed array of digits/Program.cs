using System;
using System.Linq;

namespace Convert_number_to_reversed_array_of_digits
{
    // https://www.codewars.com/kata/5583090cbe83f4fd8c000051
    // Convert number to reversed array of digits
    // Given a random number:

    // C#: long;
    // C++: unsigned long;
    // You have to return the digits of this number within an array in reverse order.

    //Example:
    // 348597 => [7,9,5,8,4,3]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Digitize(348597)));
        }

        // solution
        static long[] Digitize(long n)
        {
            return n.ToString().Select(x => long.Parse(x.ToString())).Reverse().ToArray();
        }
    }
}
