class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, Address eventAddress, string weather) : base(eventTitle, description, date, time, eventAddress, "Outdoor Event")
    {
        _weather = weather;
    }
    public override void GenerateFullDetails()
    {
        base.GenerateFullDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
    
}