using System;

namespace Finish_Guess_the_Number_Game
{
    // https://www.codewars.com/kata/568018a64f35f0c613000054
    // Imagine you are creating a game where the user has to guess the correct number.
    // But there is a limit of how many guesses the user can do.

    // If the user tries to guess more than the limit the function show throw an error
    // If the user guess wrong it should lose a life and return false (if you guess correctly you shouldn't remove a life)
    // If the user guess right it should return true
    // Can you finish the game so all the rules are met?
    class Program
    {
        static void Main(string[] args)
        {
            Guesser guesser = new Guesser(10, 2);

            Console.WriteLine(guesser.Guess(1)); // should be false
        }
    }

    // solution
    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives < 1)
                throw new Exception();

            if (n == number)
                return true;

            lives--;

            return false;
        }
    }
}
