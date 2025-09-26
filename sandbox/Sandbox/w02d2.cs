using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 2;
        int y = 3;
        int sum = Adder(x, y);
        Console.WriteLine(sum);

        GreetUser("Bob");

        string someoneName = "Jill";
        GreetUser(someoneName);

        Console.WriteLine($"x before: {x}");
        ChangeValue(x);
        Console.WriteLine($"x after: {x}");

        int[] myArray = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Before:");
        foreach (int number in myArray)
        {
            Console.Write($"{number} ");
        }

        ChangeReference(myArray);
        Console.WriteLine("After:");
        foreach (int number in myArray)
        {
            Console.Write($"{number} ");
        }

    }

    static int ChangeValue(int x)
    {
        x = 100;
        return x;
    }

    static void ChangeReference(int[] data)
    {
        data[2] = 100;
    }

    static int Adder(int a, int b)
    {
        return a + b;
    }

    static void GreetUser(string firstName)
    {
        Console.WriteLine($"Hello {firstName}");
    }
}