class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    protected string _eventType;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"""
Standard Details:
Title: {_title}
Description: {_description}
Date: {_dateTime:d}
Time: {_dateTime:t}
Address:
{_address.GetFullAddress()}
""";
    }

    public virtual string GetFullDetails()
    {
        return $"""
Full Details:
Event Type: {_eventType}
Title: {_title}
Description: {_description}
Date: {_dateTime:d}
Time: {_dateTime:t}
Address:
{_address.GetFullAddress()}
""";
    }

    public string GetShortDescription()
    {
        return $"Short Description:\n{_eventType} - {_title} on {_dateTime:d}";
    }
}