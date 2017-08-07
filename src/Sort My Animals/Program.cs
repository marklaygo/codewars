using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_My_Animals
{
    // https://www.codewars.com/kata/58ff1c8b13b001a5a50005b4
    // Consider the following class:
    // public class Animal
    // {
    //    public string Name { get; set; }
    //     public int NumberOfLegs { get; set; }
    //}

    // Write a method that accepts a list of objects of type Animal, 
    // and returns a new list.The new list should be a copy of the original list, 
    // sorted first by the animal's number of legs, and then by its name.

    // If null is passed, the method should return null. If an empty list is passed, it should return an empty list back.
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Animal { Name = "Cat", NumberOfLegs = 4 },
                new Animal { Name = "Snake", NumberOfLegs = 0 },
                new Animal { Name = "Dog", NumberOfLegs = 4 },
                new Animal { Name = "Pig", NumberOfLegs = 4 },
                new Animal { Name = "Human", NumberOfLegs = 2 },
                new Animal { Name = "Bird", NumberOfLegs = 2 }
            };

            Console.WriteLine(string.Join(", ", AnimalSorter.Sort(animals).Select(x => x.Name)));
        }
    }

    // solution
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public static class AnimalSorter
    {
        public static List<Animal> Sort(List<Animal> input)
        {
            if (input == null)
                return null;

            if (!input.Any())
                return input;

            return input.OrderBy(x => x.NumberOfLegs).ThenBy(y => y.Name).ToList();
        }
    }
}