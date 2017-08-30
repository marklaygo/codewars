using System;

namespace IsEven___Bitwise_Series
{
    // https://www.codewars.com/kata/592a33e549fe9840a8000ba1
    // Is the number even?
    // If the numbers is even return true. 
    // If it's odd, return false. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsEven(4));
        }

        // solution
        static bool IsEven(int n)
        {
            return (n & 1) == 0;
        }
    }
}
