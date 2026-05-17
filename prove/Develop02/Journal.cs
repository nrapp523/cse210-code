using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Linq;

public class Journal
{
    bool willQuit = false;
    string userFile;
    GeneratePrompt myPrompt = new GeneratePrompt();
    Entry myEntry = new Entry();

    public class fileNameStorage()
    {
        public static string userFile = "";
    }
    public void MenuString()
    {
        //Give user options
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?");
    }
    public void MenuInput()
    {
        
        do
        {
            string userInput = Console.ReadLine();
            //loop that continues until user gives appropriate input
            try
            {
                if (userInput == "1")
                {
                    this.Write();
                }
                else if (userInput == "2")
                {
                    this.Display();
                }
                else if (userInput == "3")
                {
                    this.Load();
                }
                else if (userInput == "4")
                {
                    this.Save();
                }
                else if (userInput == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an option, try again!");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            this.MenuString();

        }while (!willQuit);
        
    }
    public void Write()
    {
        
        string pickedPrompt = myEntry.GivePrompt();
        Console.WriteLine(pickedPrompt);
        string promptResponse = myEntry.GetUserInput();
        string promptDate = myPrompt.GetDate();
        myEntry.AddEntry(promptDate, promptResponse, pickedPrompt);
    }
    public void Quit()
    {
        willQuit = true;
    }
    public void Save()
    {
        List<string> promptList = myEntry.Entries;
        Console.Write("What file would you like to save the journal entry to?");
        fileNameStorage.userFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(userFile))
        {
            foreach (string item in promptList)
            {
                outputFile.WriteLine($"{item},");
            }

        }

    }
    public void Load()
    {
        Console.Write("What file would you like to load the journal entry(s) from?");
        fileNameStorage.userFile = Console.ReadLine();
        myEntry.Entries.Clear();
        string loadedEntries = System.IO.File.ReadAllText(userFile);
        List<string> individualEntries = loadedEntries.Split(',').ToList();

        foreach (string line in individualEntries)
        {
            myEntry.Entries.Add(line);

        }
        myEntry.Display();
    }
    public void Display()
    {
        myEntry.Display();
    }
}
