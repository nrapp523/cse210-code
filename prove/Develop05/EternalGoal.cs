using Spectre.Console;
class EternalGoal : Goal
{
   
    public EternalGoal()
    {
        SetName();
        SetDescription();
        SetNumberOFPoints();
        SetGoalType("EternalGoal");
    }
    public EternalGoal(string name, string description, int numberOfPoints, string statusMarker, int totalPoints) : base(name, description, numberOfPoints, statusMarker, totalPoints)
    {
            SetGoalType("EternalGoal");
    }
  
    public override string CreateStorageString()
    {
        return base.CreateStorageString();
    }
 
   
}