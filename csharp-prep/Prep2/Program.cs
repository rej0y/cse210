using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the grade percentage.
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);


        // Determine the letter grade.
        string letter;
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        // Output the letter grade.
        Console.WriteLine($"Your grade is {letter}.");


        // Determine if the user passed the class and output the encouragement.
        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("You didn't pass the class, but I believe you can do it next time.");
        }
        else
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }


    }
}