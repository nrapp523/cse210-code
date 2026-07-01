using System.Runtime.InteropServices.Java;
using System.Security.Cryptography.X509Certificates;
using Spectre.Console;
class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private string _statusMarker;
    private string _goalType;
    private int _totalPoints;
  public Goal()
  {
    _name = "";
    _description = "";
    _numberOfPoints = 0;
    _statusMarker = " ";
    _goalType = "";
    _totalPoints = 0;
  }
  public Goal(string name, string description, int numberOfPoints, 
  string statusMarker, int totalPoints)
  {
    _name = name;
    _description = description;
    _numberOfPoints = numberOfPoints;
    _statusMarker = statusMarker;
    _totalPoints = totalPoints;

  }
  public int GetTotalPoints()
  {
    return _totalPoints;
  }
  public void SetName()
  {
    AnsiConsole.Markup("[bold red]What is the name of your goal: [/]");
    _name = Console.ReadLine();
  }
  public void SetDescription()
  {
    AnsiConsole.Markup($"[bold green]Enter the description for {_name} goal: [/]");
    _description = Console.ReadLine();
  }
  public void SetNumberOFPoints()
  {
    AnsiConsole.Markup($"[bold green]Enter the points earned {_name} goal: [/]");
    _numberOfPoints = int.Parse(Console.ReadLine());
  }
  public void SetMarker(string statusmarker)
  {
    _statusMarker = statusmarker;
  }
  public string GetName()
  {
    return _name;
  }
  public string GetDescription()
  {
    return _description;
  }
  public string GetPoints()
  {
    return $"{_numberOfPoints}";
  }
  public void SetGoalType(string goalType)
  {
    _goalType = goalType;
  }
   public virtual string GetDisplayString()
    {
       
      return $"[{_statusMarker}]Name: {_name}, Description: {_description}, Points Earned: {_numberOfPoints}";
    }
    public virtual int MarkComplete()
    {
      return _numberOfPoints;
    }
 
    public virtual string CreateStorageString()
    {
      return $"{_name},{_description},{_numberOfPoints},{_statusMarker},{_goalType}, {_totalPoints}";
    }
   
    
  }

