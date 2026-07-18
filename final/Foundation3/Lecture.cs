class Lecture : Event
{
    private int _capacity;
    private string _speaker; 
    public Lecture(string eventTitle, string description, string date, string time, Address eventAddress, string eventType, int capacity, string speaker) : base(eventTitle, description, date, time, eventAddress, eventType)
    {
        _capacity = capacity;
        _speaker = speaker;
    }
}