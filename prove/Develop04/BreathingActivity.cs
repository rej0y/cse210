class BreathingActivity : Activity
{
    private int _breathInDuration;
    private int _breathOutDuration;
    public BreathingActivity(int breathInDuration, int breathOutDuration)
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _breathInDuration = breathInDuration;
        _breathOutDuration = breathOutDuration;
    }
    public void DoActivity()
    {
        DoStartingMessage();
        PreparingAnimation(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write("Breathe in... ");
            NumberTimer(_breathInDuration);

            Console.Write("Now breathe out... ");
            NumberTimer(_breathOutDuration);

            Console.WriteLine();
        }

        DoEndingMessage();
    }

}