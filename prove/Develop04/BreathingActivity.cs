class BreathingActivity : Activity
{
    private int _inhaleTime = 4;
    private int _exhaleTime = 6;
    public BreathingActivity() : base
    (
        "Breathing",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    { }
    public BreathingActivity(int inhaleTime, int exhaleTime) : this()
    {
        _inhaleTime = inhaleTime;
        _exhaleTime = exhaleTime;
    }
    public override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Timer(_inhaleTime);
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            Timer(_exhaleTime);
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}