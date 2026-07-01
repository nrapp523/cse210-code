using Spectre.Console;
class ChecklistGoal : Goal
{
    private int _numberOfTimesTilBonus;
    private int _bonus;
    private int _numberCompleted;
    public ChecklistGoal(string name, string description, int numberOfPoints, string statusMarker, int totalPoints, int numberOfTimesTilBonus, int bonus, int numberCompleted) : base(name, description, numberOfPoints, statusMarker, totalPoints)
    {
        SetGoalType("ChecklistGoal");
        _numberOfTimesTilBonus = numberOfTimesTilBonus;
        _bonus = bonus;
        _numberCompleted = numberCompleted;
    }
    public ChecklistGoal() : base()
    {
        SetName();
        SetDescription();
        SetNumberOFPoints();
        SetNumberOfTimesTilBonus();
        SetBonus();
        _numberCompleted = 0;
        SetGoalType("ChecklistGoal");
        SetMarker($"{_numberCompleted}/{_numberOfTimesTilBonus}");
    }
    public void SetNumberOfTimesTilBonus()
    {
         AnsiConsole.Markup("[bold red]How many times until you receive bonus: ");
        _numberOfTimesTilBonus = int.Parse(Console.ReadLine());
    }
    public void SetBonus()
    {
         Console.Write("How many points is the bonus: ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override int MarkComplete()
    {
        bool addBonus = CheckIfBonus();
        _numberCompleted += 1;
        SetMarker($"{_numberCompleted}/{_numberOfTimesTilBonus}");
        if(addBonus)
        {
            return base.MarkComplete() + _bonus;
        }
        else
        {
            return base.MarkComplete();
        }
    
    }
    public override string CreateStorageString()
    {
        return $"{base.CreateStorageString()},{_bonus}";
    }
    public override string GetDisplayString()
    {
        return base.GetDisplayString();
    }
    public bool CheckIfBonus()
    {
        if(_numberCompleted == _numberOfTimesTilBonus)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
    
}