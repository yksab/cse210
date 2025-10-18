public class Running : Activity
{
    private int _speed; // km per hour

    public Running(string date, int lenght, int speed) : base (date, lenght)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return (float) _speed *((float) _lenght/60);
    }

    public override float CalculatePace()
    {
        return (float) _lenght / CalculateDistance();
    }

    // public override float CalculateSpeed()
    // {return -1;}

    public override string GetSummary()
    {
        return $"{_date} Running ({_lenght} min): Distance {CalculateDistance().ToString("F2")} Km, Speed {_speed.ToString("F2")} Km/h, Pace {CalculatePace().ToString("F2")} min/km";
    }
}