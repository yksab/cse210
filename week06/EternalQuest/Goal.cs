public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string taskComplete = (IsComplete()) ? "[X]": "[ ]";

        return $"{taskComplete} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public virtual string GetName()
    {
        return _shortName;
    }
}