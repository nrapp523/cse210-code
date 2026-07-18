class Bicycle : Activity
{
    private float _speed;
    public Bicycle(string date, float lengthOfTime , float speed) : base(date, lengthOfTime, "Bicycle")
    {
        _speed = speed;
        base.SetSpeed(speed);
        base.CalculateDistance();
        base.CalculatePace();
    }
 
}