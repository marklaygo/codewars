using System;
using System.Linq;

namespace Shortest_Word
{
    // https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
    // x Simple, given a string of words, return the length of the shortest word(s).
    // String will never be empty and you do not need to account for different data types.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));
        }

        // solution
        static int FindShort(string s)
        {
            return s.Split().Select(x => x.Length).Min();
        }
    }
}
