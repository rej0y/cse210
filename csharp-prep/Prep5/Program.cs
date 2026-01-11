using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber, birthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program.");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber;
        while (!int.TryParse(Console.ReadLine(), out favoriteNumber))
        {
            Console.Write("That't not a valid integer, please try again: ");
        }
        return favoriteNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        while (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear is < 1900 or > 2026)
        {
            Console.Write("That't not a valid input, please try again: ");
        }
    }
    static int SquareNumber(int number)
    {
        return (int)Math.Pow(number, 2);
    }
    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{userName}, you will turn {2026 - birthYear} this year.");
    }
}