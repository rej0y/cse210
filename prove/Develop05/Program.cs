// Exceeded requirements:
// Added a level system based on total score.
// The player levels up every 1000 points, making the program more engaging.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            manager.DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    Console.WriteLine();
                    break;
                case "2":
                    manager.ListGoalDetails();
                    Console.WriteLine();
                    break;
                case "3":
                    manager.SaveGoals();
                    Console.WriteLine();
                    break;
                case "4":
                    manager.LoadGoals();
                    Console.WriteLine();
                    break;
                case "5":
                    manager.RecordEvent();
                    Console.WriteLine();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("That's not a valid choice; please try again.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}