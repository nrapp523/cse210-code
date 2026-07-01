using System.Diagnostics.Tracing;
using System.Net;
using System.Net.Quic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using Microsoft.VisualBasic;
using Spectre.Console;

class Menu
{
    private bool _isFinished;
    private string _userChoice;
    private string _menuString;
    private string _goalCreationString;
   // private string _goal;
   // private string _fileName = "myFile.txt";
    private Storage _storage = new Storage();
    public Menu()
    {
        _isFinished = false;
        _menuString = """
        Menu Options:
            1. Create new goal
            2. List goals
            3. Save goals
            4. Load goals
            5. Record Event
            6. Quit
        Select choice from menu: 
        """;
        _userChoice = null;
        _goalCreationString = """
        The types of goals are:
            1. Simple Goal
            2. Eternal Goal
            3. Checklist Goal
        Which type of goal would you like to create? 
        """; 
        
    }
    public void UserChoice()
    {
        AnsiConsole.Markup($"[blue bold]{_menuString}[/]");
        _userChoice = Console.ReadLine();
        if(_userChoice == "1")
        {
            CreateGoal();
        }
        else if(_userChoice == "2")
        {
            _storage.DisplayGoals();
        }
        else if(_userChoice == "3")
        {
           _storage.SaveGoals();
        }
        else if(_userChoice == "4")
        {
            _storage.LoadGoals();
        }
        else if(_userChoice == "5")
        {
            _storage.RecordEvent();
        }
        else if(_userChoice == "6")
        {
            Quit();
        }
        else
        {
            AnsiConsole.MarkupLine("[bold red]That is an incorrect input[/]");
        }

    }
    
    public void CreateGoal()
    {
        AnsiConsole.Markup($"[bold green]{_goalCreationString}[/]");
        string userResponse = Console.ReadLine();
        if (userResponse == "1")
        {
            SimpleGoal myGoal = new SimpleGoal();
            _storage.SavetoList(myGoal);
        }
        else if (userResponse == "2")
        {
            EternalGoal myGoal = new EternalGoal();
            _storage.SavetoList(myGoal);
        }
        else if(userResponse == "3")
        {
            ChecklistGoal myGoal = new ChecklistGoal();
            _storage.SavetoList(myGoal);
        }
    }




   
 
   
    public void Quit()
    {
        _isFinished = true;
    }

    public void MenuLoop()
    {
        while(_isFinished == false)
        {
            UserChoice();
        }
    }
  
}