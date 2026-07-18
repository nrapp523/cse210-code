using System.ComponentModel;

class Running : Activity
{
    public Running(string date, float lengthOfTime, float distance) : base(date, lengthOfTime, "Running")
    {
        base.SetDistance(distance);
        base.CalculatePace();
        base.CalculateSpeed();
    }

}