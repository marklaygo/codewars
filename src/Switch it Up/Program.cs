﻿using System;

namespace Switch_it_Up
{
    // https://www.codewars.com/kata/5808dcb8f0ed42ae34000031
    // When provided with a number between 0-9, return it in words.

    // Input :: 1
    // Output:: "One".

    // Try using "Switch" statements.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SwitchItUp(1));
        }

        // solution
        static string SwitchItUp(int number)
        {
            switch (number)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
            }

            return "";
        }
    }
}
