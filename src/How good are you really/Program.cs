using System;
using System.Linq;

namespace How_good_are_you_really
{
    // https://www.codewars.com/kata/5601409514fc93442500010b
    // There was a test in your class and you passed it.Congratulations!
    // But you're an ambitious person. You want to know if you're better than the average student in your class.
    // You got an array with your colleges' points. Now calculate the average to your points!

    // Return True if you're better, else False!

    // Note:
    // Your points are not included in the array of your classes points.
    // For calculating the average point you may add your point to the given array!
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 },  80));
        }

        // solution
        static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Average() <= YourPoints ? true : false;
        }
    }
}
