using System;

namespace Volume_of_a_Cuboid
{
    // https://www.codewars.com/kata/58261acb22be6e2ed800003a
    // Bob needs a fast way to calculate the volume of a cuboid with three values: length, width and the height of the cuboid.
    // Write a function to help Bob with this calculation.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getVolumeOfCubiod(2, 5, 6));
        }

        // solution
        static double getVolumeOfCubiod(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
