using System.ComponentModel.Design;
using Spectre.Console;
class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
        SetName();
        SetDescription();
        SetNumberOFPoints();
        SetGoalType("SimpleGoal");
        
    }
    public SimpleGoal(string name, string description, int numberOfPoints, string statusMarker, int totalPoints) : base(name, description, numberOfPoints, statusMarker, totalPoints)
    {
         SetGoalType("SimpleGoal");
    }
      public override int MarkComplete()
    {
        SetMarker("X");
        return base.MarkComplete();
    }

   
    
    public override string CreateStorageString()
    {
        return base.CreateStorageString();
    }
    
    
}