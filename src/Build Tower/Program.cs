using System;

namespace Build_Tower
{
    // https://www.codewars.com/kata/576757b1df89ecf5bd00073b
    // Build Tower

    // Build Tower by the following given argument:
    // number of floors(integer and always greater than 0).

    //Tower block is represented as *
    //for example, a tower of 3 floors looks like below
    // '  *  ',
    // ' *** ',
    // '*****'
    class Program
    {
        static void Main(string[] args)
        {
            var tower = TowerBuilder(3);
            
            foreach(var floor in tower)
            {
                Console.WriteLine(floor);
            }
        }

        // solution
        static string[] TowerBuilder(int nFloors)
        {
            var tower = new string[nFloors];

            for (int i = 0; i < nFloors; i++)
            {
                var space = new string(' ', nFloors - i - 1);
                var blocks = new string('*', i * 2 + 1);
                tower[i] = string.Concat(space, blocks, space);
            }

            return tower;
        }
    }
}
