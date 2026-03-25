using System.Transactions;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected double _time;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    private void Welcome()
    {
        Console.WriteLine($"Welcome to {_name} Activity.");
        Spinner();
    }
    private void DisplayDescription()
    {
        Console.WriteLine(_description);
        Spinner();
    }
    private void PromptForTime()
    {
        bool done = false;
        while (!done)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            if (
                double.TryParse
                (
                    Console.ReadLine(),
                    out double time
                )
            )
            {
                if (time > 0)
                {
                    _time = time;
                    done = true;
                }
                else
                {
                    Console.WriteLine("The value must be greater than 0; please try again.\n");
                }
            }
            else
            {
                Console.WriteLine("The value is invalid; please try again.\n");
            }
        }
    }
    private void Start()
    {
        Welcome();
        Console.WriteLine();
        DisplayDescription();
        Console.WriteLine();
        PromptForTime();
    }
    private void Transition()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner();
        Console.WriteLine();
    }
    public abstract void Run();
    private void End()
    {
        Console.WriteLine("Well done!!");
        Spinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        Spinner();
    }
    public void Execute()
    {
        Start();
        Transition();
        Run();
        End();
    }
    public void Timer(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void Spinner(int duration = 3000, int interval = 500)
    {
        var frames = new[] { '-', '\\', '|', '/' };
        int index = 0;

        DateTime endTime = DateTime.Now.AddMilliseconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[index++ % frames.Length]);
            Thread.Sleep(interval);
            Console.Write("\b \b");
        }
    }
}