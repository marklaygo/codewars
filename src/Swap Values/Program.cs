using System;
using System.Linq;

namespace Swap_Values
{
    // https://www.codewars.com/kata/5388f0e00b24c5635e000fc6
    // I would like to be able to pass an array with two elements to my swapValues function to swap the values.
    // However it appears that the values aren't changing.

    // Can you figure out what's wrong here?
    class Program
    {
        static void Main(string[] args)
        {
            int[] arguments = new[] { 1, 2 };
            Swapper swapper = new Swapper(arguments.Cast<object>().ToArray());
            swapper.SwapValues();

            Console.WriteLine($"{swapper.Arguments[0]} {swapper.Arguments[1]} ");
        }
    }

    // solution
    public class Swapper
    {
        public object[] Arguments { get; private set; }

        public Swapper(object[] args)
        {
            Arguments = args;
        }

        public void SwapValues()
        {
            object[] args = new[] { Arguments[0], Arguments[1] };

            object temp = args[0];
            args[0] = args[1];
            args[1] = temp;

            Arguments = args;
        }
    }
}
