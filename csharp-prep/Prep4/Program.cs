using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a list of numbers.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber;
        List<int> userNumbers = new List<int>();
        // User list input loop.
        do
        {
            Console.Write("Enter number: ");

            // This loop makes sure the integer.
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.Write("That's not a valid number, please try again: ");
            }

            // Add the number to the list.
            userNumbers.Add(userNumber);

        } while (userNumber != 0);

        // Calculate the sum and find out the largest number.
        int sum = 0;
        int largestNumber = userNumbers[0];
        foreach (int number in userNumbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        // Calculate the average.
        // The reason that I am -1 is because the program doesn't want to regard the last 0 as an item.
        double average = (double)sum / (userNumbers.Count - 1);

        // Find out the smallest positive number.
        // Temporary set this value to positive infinity.
        double smallestPositive = double.PositiveInfinity;
        foreach (int number in userNumbers)
        {
            if (number > 0 && (number < smallestPositive))
            {
                smallestPositive = number;
            }
        }

        // Sort the list.
        userNumbers.Sort();

        // Output the result.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in userNumbers)
        {
            Console.WriteLine(number);
        }

    }
}