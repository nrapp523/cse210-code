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
        _eventType = eventTitle;
    }
    public virtual void GenerateStandardDetails()
    {
        Console.WriteLine($"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_eventAddress.GetAddress()}");
    }


}