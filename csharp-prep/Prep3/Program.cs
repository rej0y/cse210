using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Program running loop.
        string response;
        do
        {
            // Generate the random magic number.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // User input loop.
            bool gameRunning = true;
            int guessCount = 0;
            while (gameRunning)
            {
                // Ask for the guess.
                Console.Write("What is your guess? ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    // Record the guess number.
                    guessCount++;

                    // Determine the result.
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {guessCount} guess(es).");
                        gameRunning = false;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that's not a correct input, please try again.");
                }
            }

            // User input loop.
            // Ask the user if they want to continue.
            do
            {
                Console.Write("Do you want to continue? (y/n) ");
                response = Console.ReadLine();
            } while (response != "y" && response != "n");

        } while (response == "y");
    }
}