using System;

namespace Beginner_Series_1_School_Paperwork
{
    // https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd
    // Your classmates asked you to copy some paperwork for them.You know that there are 'n' classmates and the paperwork has 'm' pages.
    // Your task is to calculate how many blank pages do you need.

    // Example:
    // Paperwork(5, 5) == 25

    // Note! if n or m< 0 return 0!

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Paperwork(5, 5));
        }

        // solution
        static int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0)
                return 0;

            return n * m;
        }
    }
}