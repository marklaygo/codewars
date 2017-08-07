using System;
using System.Collections.Generic;
using System.Linq;

namespace Friend_or_Foe
{
    // https://www.codewars.com/kata/55b42574ff091733d900002f
    // Make a program that filters a list of strings and returns a list with only your friends name in it.

    // If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours!

    // Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", FriendOrFoe(new string[] { "Ryan", "Kieran", "Jason", "Yous" })));
        }

        // solution
        static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(x => x.Length == 4);
        }
    }
}