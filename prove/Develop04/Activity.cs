class Activity
{
    protected string _name;
    protected string _description;
    protected double _time;
    private void Welcome()
    {
        Console.WriteLine($"Welcome to {_name} Activity.");
        new Spinner().Display();
    }
    private void DisplayDescription()
    {
        Console.WriteLine(_description);
        new Spinner().Display();
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
    public void Start()
    {
        Welcome();
        Console.WriteLine();
        DisplayDescription();
        Console.WriteLine();
        PromptForTime();
    }
    public void Transition()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        new Spinner().Display();
        Console.WriteLine();
    }
    public void End()
    {
        Console.WriteLine("Well done!!");
        new Spinner().Display();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        new Spinner().Display();
    }
}