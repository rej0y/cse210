class EternalGoal : Goal
{
    /// <summary>
    /// Eternal goal constructor, is the same with the base goal constructor.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="points"></param>
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    /// <summary>
    /// Overrode GetStringRepresentation() for the eternal goal, added the goal type before the string.
    /// </summary>
    /// <returns>A string representation specific to the eternal goal.</returns>
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetStringRepresentation()}";
    }
}