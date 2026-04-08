class OutdoorGatheringEvent : Event
{
    private string _weather;

    public OutdoorGatheringEvent(
        string title,
        string description,
        DateTime dateTime,
        Address address,
        string weather
    ) : base(title, description, dateTime, address)
    {
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }

    public override string GetFullDetails()
    {
        return $"""
{base.GetFullDetails()}
Weather: {_weather}
""";
    }
}