using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    
    public GoalManager()
    {
        _goals.Clear();
        _score = 0;
    }

    public void Start()
    {
        Console.Write($"\nMenu Option:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");        
    }

    public void DisplayPlayerInfo()
    {
        Console.Write($"\nYou have {_score} points.")
    }

    public void ListGoalNames()
    {
        //
    }

    public void ListGoalDetails()
    {
        //
    }

    public void CreateGoal()
    {
        Console.Write("\nThe types of Goals are:\n  1. Simple Goal\n2.  Eternal Goal\n3.  Checklist Goal\nWhich type of goal would you like to create? ");
        int goalChoice = int.parse(Read.WriteLine());

        Console.Write("What is the name of your goal? ");
        string name = Read.WriteLine();

        Console.Write("What is a short description of it? ");
        string description = Read.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.parse(Read.WriteLine());

        if (goalChoice == 1)
        {
            SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(newSimpleGoal);
        }
        else if (goalChoice == 2)
        {
            EternalGoal newEternalGoal = new EternalGoal(name, description, points);
            _goals.Add(newEternalGoal);
        }
        else if (goalChoice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTries = int.parse(Read.WriteLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.parse(Read.WriteLine());

            ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newChecklistGoal);
        }        
    }

    public void RecordEvent()
    {
        //
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.Readline();
    }

    public void LoadGoals()
    {
        //
    }
}
