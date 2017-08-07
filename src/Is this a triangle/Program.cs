using System;

namespace Is_this_a_triangle
{
    // https://www.codewars.com/kata/56606694ec01347ce800001b
    // Implement a method that accepts 3 integer values a, b, c.
    // The method should return true if a triangle can be built with the sides of given length and false in any other case.

    // (In this case, all triangles must have surface greater than 0 to be accepted).
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTriangle(5, 7, 10));
        }

        // solution
        static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }
    }
}