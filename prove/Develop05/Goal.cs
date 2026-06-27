using System.Security.Cryptography.X509Certificates;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;
  public Goal()
  {
    _name = "";
    _description = "";
    _numberOfPoints = 0;
    _status = false;
    _goalType = "";
  }
  public void SetName()
  {
    Console.Write("What is the name of your goal: ");
    _name = Console.ReadLine();
  }
  public void SetDescription()
  {
    Console.Write($"Enter the description for {_name} goal: ");
    _description = Console.ReadLine();
  }
  public void SetNumberOFPoints()
  {
    Console.Write($"Enter the points earned {_name} goal: ");
    _numberOfPoints = int.Parse(Console.ReadLine());
  }
   public virtual string GetDisplayString()
    {
        char statusMarker = ' ';
        if(_status)
        {
            statusMarker = 'X';
        }
        return $"[{statusMarker}]Name: {_name}, Description: {_description}, Points Earned: {_numberOfPoints}";
    }
    public int MarkComplete()
    {
      _status = true;
      return _numberOfPoints;
    }
    public void RemoveX()
    {
      _status = false;
    }
    public abstract void CreateGoal();
    public abstract void RecordEvent();
  }


