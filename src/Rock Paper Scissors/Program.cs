﻿using System;

namespace Rock_Paper_Scissors
{
    // https://www.codewars.com/kata/5672a98bdbdd995fad00000f
    // Rock Paper Scissors

    // Let's play! You have to return which player won! In case of a draw return Draw!.

    // Examples:
    // rps('scissors','paper') // Player 1 won!
    // rps('scissors','rock') // Player 2 won!
    // rps('paper','paper') // Draw!
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rps("scissors", "paper"));
        }

        // solution
        static string Rps(string p1, string p2)
        {
            if (p1 == p2)
                return "Draw!";

            if ((p1 == "rock" && p2 == "scissors") || (p1 == "paper" && p2 == "rock") || (p1 == "scissors" && p2 == "paper"))
                return "Player 1 won!";
            else
                return "Player 2 won!";
        }
    }
}
