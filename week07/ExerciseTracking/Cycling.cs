public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int lengthInMinutes, double speedKph)
        : base(date, lengthInMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        return (_speedKph * LengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        return 60 / _speedKph;
    }
}
