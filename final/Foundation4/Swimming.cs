class Swimming : Activity
{
    private float _numberOfLaps;
    public Swimming(string date, float lengthOfTime , float numberOfLaps) : base(date, lengthOfTime, "Swimming")
    {
        _numberOfLaps = numberOfLaps;
        CalculateDistance();
        base.CalculatePace();
        base.CalculateSpeed();
    }
    public override void CalculateDistance()
    {
        base.SetDistance(0.05f * _numberOfLaps);
    }
}