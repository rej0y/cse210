class BodyScanActivity : Activity
{
    private int _promptTime = 5;
    private List<string> _prompts = new List<string>
    ([
        "Focus on your forehead...",
        "Relax your jaw...",
        "Notice your shoulders...",
        "Let your arms feel heavy...",
        "Focus on your hands...",
        "Notice your chest rising and falling...",
        "Relax your legs...",
        "Focus on your feet...",
    ]);
    public BodyScanActivity() : base
    (
        "Body Scan",
        "This activity will help you relax by guiding your attention through different parts of your body and helping you notice and release tension."
    )
    { }
    public BodyScanActivity(int promptTime) : this()
    {
        _promptTime = promptTime;
    }
    public override void Run()
    {
        Console.WriteLine("Close your eyes if you feel comfortable.");
        Spinner();
        Console.WriteLine();

        Console.WriteLine("Take a slow breath before you begin.");
        Spinner(15000);
        Console.WriteLine();

        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.Write(_prompts[index] + " ");
            Timer(_promptTime);
            Console.WriteLine("\n");

            index = (index + 1) % _prompts.Count;
        }

        Console.WriteLine("Take one final deep breath.");
        Spinner(15000);
        Console.WriteLine();
    }
}