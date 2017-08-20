using System;
using System.Linq;

namespace A_Needle_in_the_Haystack
{
    // https://www.codewars.com/kata/56676e8fabd2d1ff3000000c
    // Can you find the needle in the haystack?
    // Write a function findNeedle() that takes an array full of junk but containing one "needle"
    // After your function finds the needle it should return a message(as a string) that says:
    // "found the needle at position " plus the index it found the needle

    // So
    // find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
    // find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
    // findNeedle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
    // findNeedle(new Object[] {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"})
    // find_needle(["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"])

    // should return
    // 'found the needle at position 5'
    // 'found the needle at position 5'
    // 'found the needle at position 5'
    // "found the needle at position 5"
    // "found the needle at position 5"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNeedle(new object[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"}));
        }

        // solution
        static string FindNeedle(object[] haystack)
        {
            return "found the needle at position " + haystack.ToList().FindIndex(x => Convert.ToString(x) == "needle").ToString();
        }
    }
}
