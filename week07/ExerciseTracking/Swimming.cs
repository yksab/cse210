public class Swimming : Activity
{
    private int _laps; // one lap equals 50 metres

    public Swimming(string date, int lenght, int laps) : base (date, lenght)
    {
        _laps = laps;
    }

    public override float CalculateDistance()
    {
        return (float) _laps * ((float) 50/1000); // return km
    }

     public override float CalculateSpeed()
    {
        return (float) CalculateDistance() * ((float) 60/_lenght);
    }

    public override float CalculatePace()
    {
        return (float) _lenght / CalculateDistance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_lenght} min): Distance {CalculateDistance().ToString("F2")} Km, Speed {CalculateSpeed().ToString("F2")} Km/h, Pace {CalculatePace().ToString("F2")} min/km";
    }
}