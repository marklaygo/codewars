using System;
using System.Numerics;

namespace Sum_Strings_as_Numbers
{
    // https://www.codewars.com/kata/5324945e2ece5e1f32000370
    // Given the string representations of two integers, return the string representation of the sum of those integers.

    // For example:
    // sumStrings('1','2') // => '3'
    // A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("1", "2"));
        }

        // solution
        static string sumStrings(string a, string b)
        {
            BigInteger firstNum, secondNum;

            BigInteger.TryParse(a, out firstNum);
            BigInteger.TryParse(b, out secondNum);

            return (firstNum + secondNum).ToString();
        }
    }
}