public class GeneratePrompt
{
    public List<string> Prompts {get; set;} = new List<string> {"What was your favorite part of your day?", "How did you see God's hand in your life today?", "How could you improve from today?", "What is one thing you learned today?", "What was your favorite part of your day?", "What is one good thing you did to help someone else today?"};

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    public string PickRandomPrompt()
    {
        string randomPrompt = Prompts[Random.Shared.Next(Prompts.Count)];
        return randomPrompt;
    }
}