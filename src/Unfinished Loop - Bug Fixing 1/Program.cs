using System;
using System.Collections.Generic;

namespace Unfinished_Loop___Bug_Fixing_1
{
    // https://www.codewars.com/kata/55c28f7304e3eaebef0000da
    // Unfinished Loop - Bug Fixing #1
    // Oh no, Timmy's created an infinite loop! Help Timmy find and fix the bug in his unfinished For Loop!
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", CreateList(2)));
        }

        // solution
        public static List<int> CreateList(int number)
        {
            List<int> list = new List<int>();

            for (int counter = 1; counter <= number; counter++)
            {
                list.Add(counter);
            }

            return list;
        }
    }
}
