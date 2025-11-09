using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool programRunning = true;
        while (programRunning)
        {
            int userChoice = DisplayAndGetMenuOption();
            if (!RunProgram(userChoice))
            {
                programRunning = false;
            }
        }
    }

    public static int DisplayAndGetMenuOption()
    {

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");

            Console.CursorVisible = true;
            Console.Write("Select a choice from the menu: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice is >= 1 and <= 4)
            {
                return choice;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That's not a correct option, please try again.\n");
            }
        }
    }
    
    public static bool RunProgram(int optionNumber)
    {
        bool programRunning = true;
        switch (optionNumber)
        {
            case 1:
                new BreathingActivity(4, 6).DoActivity();
                break;
            case 2:
                new ReflectionActivity(15).DoActivity();
                break;
            case 3:
                new ListingActivity().DoActivity();
                break;
            case 4:
                programRunning = false;
                break;
        }
        return programRunning;
    }
}