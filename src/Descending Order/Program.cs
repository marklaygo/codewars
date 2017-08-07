using System;
using System.Linq;

namespace Descending_Order
{
    // https://www.codewars.com/kata/5467e4d82edf8bbf40000155
    // Your task is to make a function that can take any non-negative integer
    // as a argument and return it with it's digits in descending order. 
    // Essentially, rearrange the digits to create the highest possible number.

    // Examples:
    // Input: 21445 Output: 54421
    // Input: 145263 Output: 654321
    // Input: 1254859723 Output: 9875543221
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(21445));
        }

        // solution
        static int DescendingOrder(int num)
        {
            return Convert.ToInt32(string.Join("", num.ToString().OrderByDescending(x => x)));
        }
    }
}