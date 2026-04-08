class ReceptionEvent : Event
{
    private string _rsvpEmail;

    public ReceptionEvent(
        string title,
        string description,
        DateTime dateTime,
        Address address,
        string rsvpEmail
    ) : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";
    }

    public override string GetFullDetails()
    {
        return $"""
{base.GetFullDetails()}
RSVP Email: {_rsvpEmail}
""";
    }
}