class SimpleGoal : Goal
{
    private bool _isComplete;

    /// <summary>
    /// Simple goal constructor, with a isComplete parameter in addition to the base goal.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="description">Goal description</param>
    /// <param name="points">The points associated with the goal</param>
    /// <param name="isComplete">Whether the goal is completed, default to false</param>
    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    /// <summary>
    /// Overrode IsComplete(), return true of false according to the variable isComplete.
    /// </summary>
    /// <returns>True of false according whether the goal is completed.</returns>
    public override bool IsComplete()
    {
        return _isComplete;
    }

    /// <summary>
    /// Overrode RecordEvent(), only return the points to the 
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Overrode GetStringRepresentation(), with is completed at the end of the string.
    /// </summary>
    /// <returns>A string representation with whether it is completed specific to the Simple goal.</returns>
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetStringRepresentation()},{IsComplete()}";
    }
}