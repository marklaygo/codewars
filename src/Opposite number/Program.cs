using System;

namespace Opposite_number
{
    // https://www.codewars.com/kata/56dec885c54a926dcd001095
    // Very simple, given a number, find its opposite.

    // Examples:
    // 1: -1
    // 14: -14
    // -34: 34

    // But can you do it in 1 line of code and without any conditionals?
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Opposite(14));
        }

        // solution 
        static int Opposite(int number)
        {
            return number * -1;
        }
    }
}