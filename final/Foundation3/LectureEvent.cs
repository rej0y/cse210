class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(
        string title,
        string description,
        DateTime dateTime,
        Address address,
        string speaker,
        int capacity
    ) : base(title, description, dateTime, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public override string GetFullDetails()
    {
        return $"""
{base.GetFullDetails()}
Speaker: {_speaker}
Capacity: {_capacity}
""";
    }
}