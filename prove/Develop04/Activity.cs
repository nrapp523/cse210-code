using System.Runtime.InteropServices.Marshalling;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }
    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.Write("How many seconds for this activity?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}: ");
        while(duration >= 0)
        {
            Console.Write($"{duration--, 2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.Write("\n");
    }
    public void WrapperForRunningActivity(Action function, Action startFunction = null)
    {
        Console.WriteLine("Get Ready...");
        Spinner(3);
        startFunction?.Invoke();
        Console.Write("\n");
        DateTime now = DateTime.Now;
        _endTime = now.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            function();
        }
        Console.Clear();

    }
    public void EndActivity()
    {
        Console.WriteLine("Well Done!!");
        Spinner(3);
        Console.Write("\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity!");
        Spinner(5);
        Console.Clear();

        
    }
    public void Spinner(int duration)
    {
        Console.CursorVisible = false;
        int sleepTime = 250;
        string animationString = "\\|/";
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(duration);
        int index = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
    protected string PickRandomListItem(List<string> inputList)
    {
        int randomIndex = Random.Shared.Next(inputList.Count);
        return inputList[randomIndex];
    }
}