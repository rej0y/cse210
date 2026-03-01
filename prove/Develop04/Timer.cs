class Timer
{
    private double _time;
    public Timer(double time)
    {
        _time = time;
    }
    public void Run()
    {
        for (double time = _time; time > 0; time--)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}