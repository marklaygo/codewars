using System;
using System.Collections.Generic;

namespace Mumbling
{
    // https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
    // This time no story, no theory.The examples below show you how to write function accum:

    // Examples:
    // Accumul.Accum("abcd");    // "A-Bb-Ccc-Dddd"
    // Accumul.Accum("RqaEzty"); // "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    // Accumul.Accum("cwAt");    // "C-Ww-Aaa-Tttt"

    // The parameter of accum is a string which includes only letters from a..z and A..Z.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accum("abcd"));
        }

        // solution
        public static String Accum(string s)
        {
            var result = new List<string>();
            var sToLower = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                result.Add(s[i].ToString().ToUpper() + new string(sToLower[i], i));
            }

            return string.Join("-", result);
        }
    }
}
