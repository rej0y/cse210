using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Output the introduction
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create a integer list.
        List<int> intList = new List<int>();

        // Continue prompting the user for input.
        bool done = false;
        while (!done)
        {
            // Ask the user for the integer.
            Console.Write("Enter number: ");
            int userInteger = int.Parse(Console.ReadLine());

            // Add the number to the list; type 0 to end the loop.
            if (!(userInteger == 0))
            {
                intList.Add(userInteger);
            }
            else
            {
                done = true;
            }
        }

        // Initialize the sum.
        int sum = 0;
        // Calculate the sum.
        foreach (int num in intList)
        {
            sum += num;
        }

        // Calculate the average.
        double average = (double)sum / intList.Count;

        // Set the smallest number default to be the first one.
        int largestInt = intList[0];
        // Look for the largest number.
        foreach (int num in intList)
        {
            if (num > largestInt)
            {
                largestInt = num;
            }
        }

        // Output the sum.
        Console.WriteLine($"The sum is: {sum}");
        // Output the average.
        Console.WriteLine($"The average is: {average}");
        // Output the largest number.
        Console.WriteLine($"The largest number is: {largestInt}");
    }
}