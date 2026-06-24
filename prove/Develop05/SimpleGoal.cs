using System.ComponentModel.Design;

class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
        SetName();
        SetDescription();
        SetNumberOFPoints();
    }
    public override void CreateGoal()
    {
        
    }
    public override void RecordEvent()
    {
        
    }
}