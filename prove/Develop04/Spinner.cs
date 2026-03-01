// Reference: https://chatgpt.com/share/69a3ce89-8828-8005-8ebb-eeca7854c156
class Spinner
{
    private double _duration;
    private int _interval;
    public Spinner(double duration = 3000, int interval = 500)
    {
        _duration = duration;
        _interval = interval;
    }
    public void Display()
    {
        var frames = new[] { '-', '\\', '|', '/' };
        int index = 0;

        DateTime endTime = DateTime.Now.AddMilliseconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[index++ % frames.Length]);
            Thread.Sleep(_interval);
            Console.Write("\b \b");
        }
    }
}