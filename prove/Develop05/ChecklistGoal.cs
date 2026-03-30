class ChecklistGoal : Goal
{
    private int _bonus;
    private int _targetCount;
    private int _amountCompleted;

    /// <summary>
    /// Checklist goal constructor, with also the bonus points, target count, and amount completed in addition to the base goal.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="description">Goal description</param>
    /// <param name="points">The points associated with the goal</param>
    /// <param name="bonus">The bonus points for the checklist goal</param>
    /// <param name="targetCount">The target finish number for the checklist goal</param>
    /// <param name="amountCompleted">The current finish number for the checklist goal</param>
    public ChecklistGoal(string name, string description, int points, int bonus, int targetCount, int amountCompleted = 0) : base(name, description, points)
    {
        _bonus = bonus;
        _targetCount = targetCount;
        _amountCompleted = amountCompleted;
    }

    /// <summary>
    /// Return a boolean if the checklist goal is completed.
    /// </summary>
    /// <returns>True or false, if the goal is completed or not.</returns>
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }

    /// <summary>
    /// Overrode RecordEvent(), returning the points of this goal or the points with the bonus points of the goal if it is completed.
    /// </summary>
    /// <returns>The points to the goal.</returns>
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

    /// <summary>
    /// Overrode GetDetailsString(), added a currently completed at the end of the string.
    /// </summary>
    /// <returns>The details string specific to the checklist goal.</returns>
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_targetCount}";
    }

    /// <summary>
    /// Overrode GetStringRepresentation(), added bonus points, target count, and amount completed at the end of the string specific to the checklist goal.
    /// </summary>
    /// <returns>A string representation specific to the checklist goal.</returns>
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetStringRepresentation()},{_bonus},{_targetCount},{_amountCompleted}";
    }
}