/*
Exceeding Requirements: I added a new activity called
"body scan activity" that can guide the user to focus
on their body parts to help them relax. I also
refined the UX a little bit and handled the input and
prevented crashes.
*/

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
            Console.WriteLine("\t2. Start body scan activity");
            Console.WriteLine("\t3. Start reflecting activity");
            Console.WriteLine("\t4. Start listing activity");
            Console.WriteLine("\t5. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Execute();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    BodyScanActivity bodyScanActivity = new BodyScanActivity();
                    bodyScanActivity.Execute();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Execute();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Execute();
                    Console.Clear();
                    break;
                case "5":
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