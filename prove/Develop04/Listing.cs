class Listing : Activity
{
    private int _responseNumber;
    private List<string> _promptList = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing(string description) : base("Listing", description)
    {

    }
    public void ListingStartFunction()
    {
        Console.WriteLine("List as many resopnses you can to the following prompt:");
        Console.WriteLine($"---{PickRandomListItem(_promptList)}");
        RunCountDown("You may begin in", 5);
    }
    public void ListingActivity()
    {
        Console.ReadLine();
        _responseNumber += 1; 
    }
    public void DisplayAmountOfItems()
    {
        Console.WriteLine($"You listed {_responseNumber} item(s)");
        Spinner(3);
        Console.Clear();
    }
    public void RunActivity()
    {
        WrapperForRunningActivity(ListingActivity, ListingStartFunction);
    }
    
}