using System;

namespace Beginner_Series_4_Cockroach
{
    // https://www.codewars.com/kata/55fab1ffda3e2e44f00000c6
    // Cockroach is one of the fastest insects.Write a function which takes its speed in km per hour and returns the number of whole(floored) cm it moves per second.

    // Example: 
    // CockroachSpeed(1.08) == 30

    // Note! The input is a Real number(actual type is language dependent) and is >= 0. The result should be an Integer.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CockroachSpeed(1.08));
        }

        // solution
        static int CockroachSpeed(double x)
        {
            double cm = 100000;
            double second = 3600;

            return (int)((x * cm) / second);
        }
    }
}