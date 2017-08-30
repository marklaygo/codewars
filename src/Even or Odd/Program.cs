using System;

namespace Even_or_Odd
{
    // https://www.codewars.com/kata/53da3dbb4a5168369a0000fe
    // Create a function that takes an integer as an argument
    // and returns "Even" for even numbers or "Odd" for odd numbers.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(5));
        }

        // solution
        static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
