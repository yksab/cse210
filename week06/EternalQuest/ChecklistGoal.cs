public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete() == false)
        {
            ++_amountCompleted;

            if (IsComplete() == false)
            {
                return int.Parse(_points);
            }
            else
            {
                return int.Parse(_points) + _bonus;
            } 
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return (_amountCompleted == _target) ? true: false;
    }

    public override string GetDetailsString()
    {
        string taskComplete = (IsComplete()) ? "[X]": "[ ]";

        return $"{taskComplete} {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"C,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}