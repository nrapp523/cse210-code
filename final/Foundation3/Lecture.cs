class Lecture : Event
{
    private int _capacity;
    private string _speaker; 
    public Lecture(string eventTitle, string description, string date, string time, Address eventAddress, int capacity, string speaker) : base(eventTitle, description, date, time, eventAddress, "Lecture")
    {
        _capacity = capacity;
        _speaker = speaker;
    }
    public override void GenerateFullDetails()
    {
        base.GenerateFullDetails();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }
}