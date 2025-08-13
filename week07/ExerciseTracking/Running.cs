public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int lengthInMinutes, double distanceKm)
        : base(date, lengthInMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }
}
