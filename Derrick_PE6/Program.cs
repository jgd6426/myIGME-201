using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derrick_PE6
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE6 - Parsing and Formatting
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: create a simple number guessing game.
        //          generate a random number between 0-100 (inclusive) and have the player guess it
        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            // print random number for testing purposes
            //Console.WriteLine(randomNumber);

            // turn counter
            int turn = 1;

            // prompt user to guess a number
            Console.WriteLine("Turn #" + turn + ": Enter your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            // check if input is valid 
            if (guess < 0 || guess > 100)
            {
                // keep asking until guess is valid
                while (guess < 0 || guess > 100)
                {
                    Console.WriteLine("Turn #" + turn + ": Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }

            // once guess is valid tell user if guess is too high, low, or correct and track turns
            for (turn = 2; turn < 9; turn++)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Too high");
                    Console.WriteLine("Turn #" + turn + ": Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low");
                    Console.WriteLine("Turn #" + turn + ": Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    // guessed correctly tell how many turns it took and end loop
                    Console.WriteLine("\nCorrect! You won in " + (turn - 1) + " turns.");
                    break;
                }
            }
            // if not guessed correctly when turns end tell user what the number was
            Console.WriteLine("\nYou ran out of turns. The number was " + randomNumber + ".");
        }
    }
}
