class Reception : Event
{
    private string _rsvpInfo;
    public Reception(string eventTitle, string description, string date, string time, Address eventAddress, string rsvpInfo) : base(eventTitle, description, date, time, eventAddress, "Reception")
    {
        _rsvpInfo = rsvpInfo;
    }
    public override void GenerateFullDetails()
    {
        base.GenerateFullDetails();
        Console.WriteLine($"RSVP through {_rsvpInfo}");
    }
}