using System;
using System.Linq;

namespace Pre_FizzBuzz_Workout_1
{
    // https://www.codewars.com/kata/569e09850a8e371ab200000b
    // This is the first step to understanding FizzBuzz.
    // Your inputs: a positive integer, n, greater than or equal to one.
    // n is provided, you have NO CONTROL over its value.
    // Your expected outputs: an array of positive integers from 1 to n
    // Your job is to write an algorithm that gets you from the input to the output.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", PreFizz(5)));
        }

        // solution
        static int[] PreFizz(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}
