using System;
using System.Linq;

namespace String_repeat
{
    // https://www.codewars.com/kata/57a0e5c372292dd76d000d7e
    // Write a function called repeatStr which repeats the given string string exactly n times.

    // repeatStr(6, "I") // "IIIIII"
    // repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatStr(5,"Hello"));
        }

        // solution
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
        }
    }
}
