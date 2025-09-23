using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        // Game while loop.
        bool gameRunning = true;
        while (gameRunning)
        {

            // Used for debugging.
            // // Ask the user for the magic number.
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());


            // Generate a random magic number between 1 and 100.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);



            // Initialize user attempt counts.
            int userAttemptCount = 0;


            // Main game while loop.
            bool done = false;
            while (!done)
            {

                // Ask the user for the guess number.
                Console.Write("What is your guess? ");
                int userGuessNumber = int.Parse(Console.ReadLine());


                // Determine if the number that the user guessed is lower or higher.
                if (userGuessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    done = true;
                }


                // Count the attempt.
                userAttemptCount++;
            }


            // Initialize plural character.
            string pluralCharacter = "";

            // If more than 1 attempt, use plural grammar.
            if (userAttemptCount > 1)
            {
                pluralCharacter = "s";
            }


            // Output the attempt number.
            Console.WriteLine($"\nIt took you {userAttemptCount} attempt{pluralCharacter}.\n");



            // While loop to determine if the user wants to play again.
            bool playDeterminationRunning = true;
            while (playDeterminationRunning)
            {

                // Ask the user if he/she wants to play again.
                Console.Write("Do you want to play again? [Y/n] ");
                string userPlayDecisionInput = Console.ReadLine().ToLower();

                // Detemine if the game will continue running.
                switch (userPlayDecisionInput)
                {
                    case "y":
                    case "":
                        playDeterminationRunning = false;
                        break;
                    case "n":
                        gameRunning = false;
                        playDeterminationRunning = false;
                        break;
                    default:
                        Console.WriteLine("That's not a valid answer, please try again.");
                        break;
                }

                // Blank line.
                Console.WriteLine();
            }
        }

        // If we jump out of the game loop, output the message.
        Console.WriteLine("Bye");
    }
}