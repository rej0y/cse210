class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    ([
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    ]);
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        string prompt = _prompts[Random.Shared.Next(_prompts.Count)];

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        new Timer(5).Run();
        Console.WriteLine("\n");

        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        Console.WriteLine();
    }
}