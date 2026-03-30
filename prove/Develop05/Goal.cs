abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    /// <summary>
    /// Goal constructor, accept a name, description and the points associated with this goal.
    /// </summary>
    /// <param name="name">Goal name</param>
    /// <param name="description">Goal description</param>
    /// <param name="points">The points associated with the goal</param>
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    /// <summary>
    /// Get the name of the goal.
    /// </summary>
    /// <returns>String goal name.</returns>
    public string GetName()
    {
        return _name;
    }

    /// <summary>
    /// Get the detailed goal string.
    /// </summary>
    /// <returns>The base for detailed goal string: "[X] Goal name (goal description)"</returns>
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? 'X' : ' ')}] {_name} ({_description})";
    }

    /// <summary>
    /// Return a boolean whether the goal is completed.
    /// </summary>
    /// <returns>Return a boolean whether the goal is completed, default to false.</returns>
    public virtual bool IsComplete()
    {
        return false;
    }

    /// <summary>
    /// RecordEvent() returns the points associated with the goal when it is called.
    /// </summary>
    /// <returns>The points associated with the goal.</returns>
    public virtual int RecordEvent()
    {
        return _points;
    }

    /// <summary>
    /// Get the string representation of the goal used to store the data.
    /// </summary>
    /// <returns>A base string representation: "name,goal description,30"</returns>
    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points}";
    }
}