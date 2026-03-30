class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return base.RecordEvent();
        }
        else
        {
            return 0;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetStringRepresentation()},{IsComplete()}";
    }
}