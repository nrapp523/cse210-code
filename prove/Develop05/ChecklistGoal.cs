class ChecklistGoal : Goal
{
    private int _numberOfTimesTilBonus;
    private int _bonus;
    public ChecklistGoal()
    {
        SetName();
        SetDescription();
        SetNumberOFPoints();
        SetNumberOfTimesTilBonus();
        SetBonus();
    }
    public void SetNumberOfTimesTilBonus()
    {
         Console.Write("How times until you receive bonus: ");
        _numberOfTimesTilBonus = int.Parse(Console.ReadLine());
    }
    public void SetBonus()
    {
         Console.Write("How many points is the bonus: ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override void CreateGoal()
    {
      
    }
    public override void RecordEvent()
    {
        
    }
    public override string GetDisplayString()
    {
        return $"{base.GetDisplayString()}, Events until Bonus: {_numberOfTimesTilBonus}, Bonus Points: {_bonus}";
    }
}