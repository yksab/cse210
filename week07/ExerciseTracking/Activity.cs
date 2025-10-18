public abstract class Activity
{
    protected string _date; // 03 Nov 2022 - date formate
    protected int _lenght; // time of the activity in minutes

    public Activity(string date, int lenght)
    {
        _date = date;
        _lenght = lenght;
    }

    // public int GetTime()
    // {
    //     return _lenght;
    // }

    public virtual float CalculateDistance()
    {
        return -1;
    }

    public virtual float CalculateSpeed()
    {
        return -1;
    }

    public abstract float CalculatePace();

    public abstract string GetSummary();
}