using System;

class Program
{
    static void Main(string[] args)
    {
       // Goal myGoal = new Goal();
       // myGoal.SetName();
        //myGoal.SetDescription();
        //myGoal.SetNumberOFPoints();

        SimpleGoal myGoal = new SimpleGoal();
        myGoal.CreateGoal();
        Console.WriteLine(myGoal.GetDisplayString());
        myGoal.MarkComplete();
        Console.WriteLine(myGoal.GetDisplayString());
    }
   
}