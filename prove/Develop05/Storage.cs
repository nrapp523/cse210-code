using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using Spectre.Console;
class Storage
{
    private List<Goal> _goalList = new List<Goal>();
    private string _fileName = "myFile.txt";
   // private string _line;
   // private Goal _myGoal;
    private int _totalPoints = 0;

    public void SavetoList(Goal myGoal)
    {
        _goalList.Add(myGoal);
    }
    public void DisplayGoals()
    {
        int goalNumber = 1;
        foreach(Goal myGoal in _goalList)
        {
            Console.WriteLine($"{goalNumber}.{myGoal.GetDisplayString()}");
            goalNumber += 1;
        }
    }
    public void LoadGoals()
    {
        _goalList = new List<Goal>();
        AnsiConsole.Markup("[bold green]Which file do you want to load? [/]");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            string description = parts[1];
            string points = parts[2];
            string marker = parts[3];
            string goalType = parts[4];
            int totalPoints = int.Parse(parts[5]);
            int timeTilBonus = 0;
            try
            {
                timeTilBonus = int.Parse(parts[6]);
            }
            catch
            {

            }
            int bonus = 0;
            try
            {
                bonus = int.Parse(parts[7]);
            }
            catch
            {

            }
            int timesCompleted = 0;
            try
            {
                timesCompleted = int.Parse(parts[8]);
            }
            catch
            {

            }

            if(goalType == "SimpleGoal")
            {
                SimpleGoal myGoal = new SimpleGoal(name, description, int.Parse(points), marker, totalPoints);
                _goalList.Add(myGoal);
                _totalPoints = myGoal.GetTotalPoints();
            }
            else if(goalType == "EternalGoal")
            {
                EternalGoal myGoal = new EternalGoal(name, description, int.Parse(points), marker, totalPoints);
                _goalList.Add(myGoal);
                _totalPoints = myGoal.GetTotalPoints();
            }
            else if(goalType == "ChecklistGoal")
            {
                ChecklistGoal myGoal = new ChecklistGoal(name, description, int.Parse(points), marker, totalPoints, timeTilBonus, bonus, timesCompleted);
                _goalList.Add(myGoal);
                _totalPoints = myGoal.GetTotalPoints();
            }
            


        }
        DisplayGoals();

    }
    public void WriteToFile(string inputString)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {
            outputFile.WriteLine($"{inputString}");
        }
    }
    public int FindNumberOfLines()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int numberOfLines = 0;
        foreach (string line in lines)
        {
           numberOfLines += 1;
        }
        return numberOfLines;

    }
  /*  public void retrieveObject(int lineChoice)
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        _line = lines[lineChoice];
    }*/
    /*public void CreateObject()
    {
        
        List<string> componentList = _line.Split(",").ToList();
        if (componentList[4] == "SimpleGoal")
        {
              _myGoal = new SimpleGoal(componentList[0], componentList[1], int.Parse(componentList[2]), componentList[3]); 
              
        }
        else if(componentList[4] == "EternalGoal")
        {
              _myGoal = new EternalGoal(componentList[0], componentList[1], int.Parse(componentList[2]), componentList[3]);  
        }
        else if(componentList[4] == "EternalGoal")
        {
              _myGoal = new ChecklistGoal(componentList[0], componentList[1], int.Parse(componentList[2]), componentList[3],int.Parse(componentList[4]), int.Parse(componentList[5]),int.Parse(componentList[6]));
        }
        
    }*/
   /* public Goal GetGoal()
    {
        return _myGoal;
    }*/
    public void SetFile(string fileName)
    {
        _fileName = fileName;
    }
     public void SaveGoals()
    {
        AnsiConsole.Markup("[bold green]What file would you like to Save to? [/]");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(Goal myGoal in _goalList)
            {
                outputFile.WriteLine(myGoal.CreateStorageString());
            }
        }
    }
       public void RecordEvent()
    {
        DisplayGoals();
        AnsiConsole.Markup("[bold red]Which goal would you like to complete? [/]");
        int userResponse = int.Parse(Console.ReadLine());
        Goal myGoal = _goalList[userResponse-1];
        int addedPoints = myGoal.MarkComplete();
        AnsiConsole.MarkupLine($"[bold yellow]Congrats you earned {addedPoints} points[/]");
        _totalPoints += addedPoints;
        AnsiConsole.MarkupLine($"[bold yellow]You now have {_totalPoints} points[/]");

    }
   

}