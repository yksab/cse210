public class Cycling : Activity
{
    private int _distance; // km

    public Cycling(string date, int lenght, int distance) : base (date, lenght)
    {
        _distance = distance;
    }

     public override float CalculateSpeed()
    {
        return (float)_distance * ((float) 60 /_lenght);
    }

    public override float CalculatePace()
    {
        return (float) _lenght / _distance;
    }

    // public override float CalculateDistance()
    // {return -1;}

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_lenght} min): Distance {_distance.ToString("F2")} Km, Speed {CalculateSpeed().ToString("F2")} Km/h, Pace {CalculatePace().ToString("F2")} min/km";
    }
}