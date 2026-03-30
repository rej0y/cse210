class ChecklistGoal : Goal
{
    private int _bonus;
    private int _targetCount;
    private int _amountCompleted;
    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int amountCompleted = 0) : base(name, description, points)
    {
        _bonus = bonus;
        _targetCount = targetCount;
        _amountCompleted = amountCompleted;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }
    public override int RecordEvent()
    {
        if (_amountCompleted < _targetCount)
        {
            _amountCompleted += 1;

            if (_amountCompleted == _targetCount)
            {
                return base.RecordEvent() + _bonus;
            }
            else
            {
                return base.RecordEvent();
            }
        }
        else
        {
            return 0;
        }
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_targetCount}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetStringRepresentation()},{_bonus},{_targetCount},{_amountCompleted}";
    }
}