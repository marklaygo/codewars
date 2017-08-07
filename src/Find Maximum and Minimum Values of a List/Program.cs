using System;
using System.Linq;

namespace Find_Maximum_and_Minimum_Values_of_a_List
{
    // https://www.codewars.com/kata/577a98a6ae28071780000989
    // Your task is to make two functions, max and min(maximum and minimum in PHP)
    // that take a(n) array/vector of integers list as input and outputs, respectively,
    // the largest and lowest number in that array/vector.

    // # Examples

    // max({4,6,2,1,9,63,-134,566}) returns 566
    // min({ -52, 56, 30, 29, -54, 0, -110}) returns -110
    // max({ 5}) returns 5
    // min({ 42, 54, 65, 87, 0}) returns 0

    // #Notes
    // You may consider that there will not be any empty arrays/vectors.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4, 6, 2, 1, 9, 63, -134, 566");
            Console.WriteLine($"Min: {Min(new int[] { 4, 6, 2, 1, 9, 63, -134, 566 })}");
            Console.WriteLine($"Max: {Max( new int[] { 4, 6, 2, 1, 9, 63, -134, 566 })}");
        }

        // solution
        static int Min(int[] list)
        {
            return list.Min();
        }

        static int Max(int[] list)
        {
            return list.Max();
        }
    }
}