using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the grade percentage.
        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();

        // Try transfer the userValue to an integer and determine the letter grade.
        if (double.TryParse(userValue, out double gradePercentageDouble) && gradePercentageDouble >= 0)
        {
            // Round gradePercentageDouble to an integer.
            int gradePercentage = (int)Math.Round(gradePercentageDouble);

            // Initialize.
            string letterGrade;
            bool passClass;

            // Determine the letter grade and whether the class was passed.
            if (gradePercentage >= 70)
            {
                passClass = true;
                if (gradePercentage >= 90)
                {
                    letterGrade = "A";
                }
                else if (gradePercentage >= 80)
                {
                    letterGrade = "B";
                }
                else
                {
                    letterGrade = "C";
                }
            }
            else
            {
                passClass = false;
                if (gradePercentage >= 60)
                {
                    letterGrade = "C";
                }
                else
                {
                    letterGrade = "F";
                }
            }

            // Determine the sign.
            string sign;
            int lastDigit = Math.Abs(gradePercentage % 10);
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            // Handle the letter grade A and F.
            if (gradePercentage >= 97)
                sign = "";
            else if (gradePercentage < 60)
                sign = "";

            // Output the result.
            Console.WriteLine();
            Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");
            if (passClass)
            {
                Console.WriteLine("Congratulations! You passed the class.");
            }
            else
            {
                Console.WriteLine("You didn't pass the class, but I believe you can do it next time.");
            }
        }
        else
        {
            Console.WriteLine("That's not a valid input, please try again.");
        }

    }
}