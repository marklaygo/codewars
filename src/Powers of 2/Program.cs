using System;
using System.Numerics;

namespace Powers_of_2
{
    // https://www.codewars.com/kata/57a083a57cb1f31db7000028
    // Write a function powersOfTwo which will return list of all powers of 2 from 0 to n(where n is an exponent).

    // E.g:
    // n = 0 -> 2^0 -> [1]
    // n = 1 -> 2^0, 2^1 -> [1,2]
    // n = 2 -> 2^0, 2^1, 2^2 -> [1,2,4]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(',', PowersOfTwo(2)));
        }

        // solution
        static BigInteger[] PowersOfTwo(int n)
        {
            var result = new BigInteger[n + 1];

            for (int i = 0; i <= n; i++)
                result[i] = (BigInteger)Math.Pow(2, i);

            return result;
        }
    }
}
