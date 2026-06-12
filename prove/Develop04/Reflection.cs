using System.Reflection.Emit;

class Reflection : Activity
{
    public Reflection(string description) : base("Reflection", description)
    {

    }
    private List<string> _promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public void ReflectionStartFunction()
    {
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine($"---{PickRandomListItem(_questionList)}---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they realted to this experinece.");
        RunCountDown("You may begin in: ", 5);
        Console.Clear();
    }
    public void ReflectionActivity()
    {
        Console.Write(PickRandomListItem(_questionList));
        Spinner(6);
        Console.Write("\n");
    }
    public void RunActivity()
    {
        WrapperForRunningActivity(ReflectionActivity,ReflectionStartFunction);
    }
    


}