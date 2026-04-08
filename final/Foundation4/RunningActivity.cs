class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _lengthMinutes * 60;
    }

    public override double GetPace()
    {
        return _lengthMinutes / _distance;
    }
}