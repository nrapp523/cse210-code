public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
       _top = 1;
       _bottom = 1;
    }
    public Fraction(int topNum)
    {
        _top = topNum;
        _bottom = 1;
    }
    public Fraction(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }

    public void GetTop()
    {
        int topNumber = _top;
        Console.WriteLine(topNumber);
    }
    public void SetTop(int topNum)
    {
        _top = topNum;
    }
    public void GetBottom()
    {
        int bottomNumber = _bottom;
        Console.WriteLine(bottomNumber);
    }

    public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        double topNumber = _top;
        double bottomNumber = _bottom;

        double decimalValue = topNumber/bottomNumber;
        return decimalValue;
    }

}
