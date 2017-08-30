using System;
using System.Linq;

namespace Sum_of_numbers_from_0_to_N
{
    // https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763
    //Description:
    //We want to generate a function that computes the series starting from 0
    // and ending until the given number following the sequence:
    //0 1 3 6 10 15 21 28 36 45 55 ....
    //which is created by
    //0, 0+1, 0+1+2, 0+1+2+3, 0+1+2+3+4, 0+1+2+3+4+5, 0+1+2+3+4+5+6, 0+1+2+3+4+5+6+7 etc..

    //Input:
    //LastNumber

    //Output:
    //series and result

    //Example:
    //Input:
    //> 6
    //Output:
    //0+1+2+3+4+5+6 = 21
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShowSequence(6));
        }

        // solution
        static string ShowSequence(int n)
        {
            if (n == 0)
                return "0=0";
            if (n < 0)
                return n + "<0";

            var numbers = Enumerable.Range(0, n + 1);
            return String.Join("+", numbers) + $" = {numbers.Sum()}";
        }
    }
}
