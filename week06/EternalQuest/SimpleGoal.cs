public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, bool IsComplete) : base(name, description, points)
    {
        _isComplete = IsComplete;
    }

    public override int RecordEvent()
    {
        if (IsComplete() == false)
        {
            _isComplete = true;

            return int.Parse(_points);
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"G,{_shortName},{_description},{_points},{IsComplete()}";
    }
}