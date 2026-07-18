class Activity
{
    private string _date;
    private float _lengthOfTime;
    private string _activityType;
    private float _distance;
    private float _speed;
    private float _pace;
    public Activity(string date, float lengthOfTime, string activityType)
    {
        _date = date;
        _lengthOfTime= lengthOfTime;
        _activityType = activityType;
    }
    public void SetDistance(float distance)
    {
        _distance = distance;
    }
   
    public void SetPace(float pace)
    {
        _pace = pace;
    }
    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    public virtual void CalculateDistance()
    {
        SetDistance((_lengthOfTime/60) * _speed);
    }
    public virtual void CalculateSpeed()
    {
       SetSpeed(_distance/(_lengthOfTime/60));  
    }
    public virtual void CalculatePace()
    {
        SetPace(_lengthOfTime/_distance);
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_lengthOfTime:F0} min)- Distance {_distance:F1} km, Speed {_speed:F1} kph, Pace: {_pace:F2} min per km");
    }
    public float GetLengthOfTime()
    {
        return _lengthOfTime;
    }
    public void PrintPace()
    {
        Console.WriteLine(_pace);
    }

}