using System;

namespace Sum_of_the_first_nth_term_of_Series
{
    // Your task is to write a function which returns the sum of following series upto nth term(parameter).

    // Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...

    // ###Rules:
    // You need to round the answer to 2 decimal places and return it as String.
    // If the given value is 0 then it should return 0.00
    // You will only be given Natural Numbers as arguments.

    // ###Examples:
    // SeriesSum(1) => 1 = "1.00"
    // SeriesSum(2) => 1 + 1 / 4 = "1.25"
    // SeriesSum(5) => 1 + 1 / 4 + 1 / 7 + 1 / 10 + 1 / 13 = "1.57"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(seriesSum(5));
        }

        // solution
        static string seriesSum(int n)
        {
            double answer = 0;
            double divisor = 1;

            for (int i = 0; i < n; i++)
            {
                answer += 1 / divisor;
                divisor += 3;
            }

            return answer.ToString("N2");
        }
    }
}
