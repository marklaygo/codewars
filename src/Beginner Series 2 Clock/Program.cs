using System;

namespace Beginner_Series_2_Clock
{
    // https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a
    // Clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.

    // Your task is to make 'Past' function which returns time converted to miliseconds.

    // #####Example:
    // Past(0, 1, 1) == 61000

    // Note! h, m and s will be only Natural numbers!

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Past(0, 1, 1));
        }

        // solution
        static int Past(int h, int m, int s)
        {
            return (int)new TimeSpan(h, m, s).TotalMilliseconds;
        }
    }
}