using System;

namespace Recursion_1___Factorial
{
    // https://www.codewars.com/kata/5694cb0ec554589633000036
    // #1 - Factorial
    // In mathematics, the factorial of a non-negative integer n, denoted by n!, 
    // is the product of all positive integers less than or equal to n.For example,

    // 5! = 5 * 4 * 3 * 2 * 1 = 120.

    // The value of 0! is 1.

    // # Your task
    // You have to create the function factorial that receives n and returns n!.
    // You have to use recursion.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        // solution
        static ulong Factorial(ulong n)
        {
            checked
            {
                return n == 0 ? 1 : n * Factorial(n - 1);
            }
        }
    }
}
