class Goal
{
    private string _name;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? 'X' : ' ')}] {_name} ({_description})";
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual int RecordEvent()
    {
        return _points;
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points}";
    }
}