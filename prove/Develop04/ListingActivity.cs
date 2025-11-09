class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void DoActivity()
    {
        DoStartingMessage();
        PreparingAnimation(5);

        Console.WriteLine("List as many responses you can to the following prompt:\n");
        int randomPromptIndex = new Random().Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randomPromptIndex]} ---\n");

        Console.Write("You may begin in: ");
        NumberTimer(5);
        Console.WriteLine();

        Console.CursorVisible = true;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        Console.CursorVisible = false;

        Console.WriteLine();
        DoEndingMessage();
    }
}