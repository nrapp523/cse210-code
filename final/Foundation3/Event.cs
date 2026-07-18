class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _eventAddress;
    private string _eventType;
    public Event(string eventTitle, string description, string date, string time, Address eventAddress, string eventType)
    {
        _eventAddress = eventAddress;
        _date = date;
        _time = time;
        _description = description;
        _eventTitle = eventTitle;
        _eventAddress = eventAddress;
        _eventType = eventType;
    }
    public void GenerateStandardDetails()
    {
        Console.WriteLine("Standard Details-");
        Console.WriteLine($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_eventAddress.GetAddress()}");
    }
    public virtual void GenerateFullDetails()
    {
        Console.WriteLine("Full Details-");
        Console.WriteLine($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_eventAddress.GetAddress()}\nEvent Type: {_eventType}");
    }
    public void GenerateShortDetails()
    {
        Console.WriteLine("Shortened Details-");
        Console.WriteLine($"Event Type: {_eventType}\nEvent Title: {_eventTitle}\nDate: {_date}");
    }

    


}