class ChecklistGoal : Goal
{
    private int _numberOfTimesTilBonus;
    private int _bonus;
    private int _numberCompleted;
    public ChecklistGoal()
    {
        SetName();
        SetDescription();
        SetNumberOFPoints();
        SetNumberOfTimesTilBonus();
        SetBonus();
        _numberCompleted = 0;
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
        return $"[{_numberCompleted}/{_numberOfTimesTilBonus}]Name: {base.GetName()}, Description: {base.GetDescription()}, Points Earned: {base.GetPoints()} Events until Bonus: {_numberOfTimesTilBonus}, Bonus Points: {_bonus}";
    }
}