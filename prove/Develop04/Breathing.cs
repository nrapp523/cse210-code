class Breathing  : Activity
{
    public Breathing(string description) : base("Breathing", description)
    {

    }
    public void BreathingActivity()
    {
        RunCountDown("Breath In", 4);
        RunCountDown("Breath out", 6);
        Console.Write("\n");
    }
    public void RunActivity()
    {
        WrapperForRunningActivity(BreathingActivity);
    }

}