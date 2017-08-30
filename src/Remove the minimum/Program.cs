﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_the_minimum
{
    // https://www.codewars.com/kata/563cf89eb4747c5fb100001b
    // The museum of incredible dull things
    // The museum of incredible dull things wants to get rid of some exhibitions.Miriam, 
    // the interior architect, comes up with a plan to remove the most boring exhibitions.
    // She gives them a rating, and then removes the one with the lowest rating.
    // However, just as she finished rating all exhibitions,
    // she's off to an important fair,
    // so she asks you to write a program that tells her the ratings of the items after one removed the lowest one.
    // Fair enough.

    // Task
    // Given an array of integers, remove the smallest value.
    // Do not mutate the original array/list.
    // If there are multiple elements with the same value, remove the one with a lower index.
    // If you get an empty array/list, return an empty array/list.
    // Don't change the order of the elements that are left.

    // Examples
    // Remover.RemoveSmallest(new List<int>{1,2,3,4,5}) = new List<int>{2,3,4,5}
    // Remover.RemoveSmallest(new List<int>{5,3,2,1,4}) = new List<int>{5,3,2,4}
    // Remover.RemoveSmallest(new List<int>{2,2,1,2,1}) = new List<int>{2,2,2,1}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 })));
        }

        // solution
        static List<int> RemoveSmallest(List<int> numbers)
        {
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }
    }
}
