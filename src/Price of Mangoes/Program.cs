using System;

namespace Price_of_Mangoes
{
    // https://www.codewars.com/kata/57a77726bb9944d000000b06
    // There's a 3 for 2 offer on mangoes. 
    // For a given price and quantity, calculate the total cost of the mangoes.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mango(3, 3));
        }

        // solution
        static int Mango(int quantity, int price)
        {
            return price * (quantity - (quantity / 3));
        }
    }
}
