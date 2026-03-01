class BreathingActivity : Activity
{
    private double _inhaleTime = 4;
    private double _exhaleTime = 6;
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public BreathingActivity(double inhaleTime, double exhaleTime) : this()
    {
        _inhaleTime = inhaleTime;
        _exhaleTime = exhaleTime;
    }
    public void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            new Timer(_inhaleTime).Run();
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            new Timer(_exhaleTime).Run();
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}