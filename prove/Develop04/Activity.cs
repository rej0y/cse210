class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        _name = "Unknown Name";
        _description = "Unknown Description";
        _duration = -1;
    }
    protected void DoStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");

        Console.Write($"How long, in second, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void DoEndingMessage()
    {
        Console.WriteLine("Well done!!");
        SpinnerAnimation(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        SpinnerAnimation(3);
        Console.Clear();
    }

    protected void PreparingAnimation(int duration)
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.WriteLine("Get ready...");
        SpinnerAnimation(duration);
    }

    protected void SpinnerAnimation(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now <= endTime)
        {
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
    protected void NumberTimer(int duration)
    {
        while (duration > 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration -= 1;
        }
        Console.WriteLine();
    }
}