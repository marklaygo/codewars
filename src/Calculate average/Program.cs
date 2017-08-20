using System;
using System.Linq;

namespace Calculate_average
{
    // https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
    // Write function avg which calculates average of numbers in given list.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 }));
        }

        // solution
        static double FindAverage(double[] array)
        {
            return array.Length > 0 ? array.Sum() / array.Length : 0;
        }
    }
}
