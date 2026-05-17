public class Entry()
{
    public List<string> Entries = new List<string>();
    public void Display()
    {
        string absolutePath = "Not saved to file yet";

        try
        {
            absolutePath = Path.GetFullPath(Journal.fileNameStorage.userFile);
        }
        catch (Exception e)
        {
            
        }
        Console.WriteLine(absolutePath);
        foreach (string item in Entries)
        {
            
            Console.WriteLine(item);
        }
        
    }
    public string GivePrompt()
    {
        GeneratePrompt myPrompt = new GeneratePrompt();
        string userPrompt = myPrompt.PickRandomPrompt();
        return userPrompt;
    }
    public string GetUserInput()
    {
        string userInput = Console.ReadLine();
        return userInput;
    }
    public void AddEntry(string theDate, string userInput, string thePrompt)
    {
       Entries.Add($"Date: {theDate}\nPrompt: {thePrompt}\nThe Response: {userInput}\n\n"); 
    }

    
}