using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    breathingActivity.Transition();
                    breathingActivity.Run();
                    breathingActivity.End();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Start();
                    reflectingActivity.Transition();
                    reflectingActivity.Run();
                    reflectingActivity.End();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    listingActivity.Transition();
                    listingActivity.Run();
                    listingActivity.End();
                    Console.Clear();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input, please try again.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}