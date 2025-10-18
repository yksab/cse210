using System;
using  System.IO;

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
        Console.Write($"\nYou have {_score} points.");
    }

    public void ListGoalNames( )
    {
        Console.WriteLine("The Goals are:");

        int count = 1;

        foreach(Goal goal in _goals)
        {  
            Console.WriteLine($"{count}. {goal.GetName()}");
            
            count++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");

        int count = 1;

        foreach(Goal goal in _goals)
        {
            
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            
            count++;
        }
    }

    public void CreateGoal()
    {
        Console.Write("\nThe types of Goals are:\n  1. Simple Goal\n2.  Eternal Goal\n3.  Checklist Goal\nWhich type of goal would you like to create? ");
        int goalChoice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

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
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newChecklistGoal);
        }        
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        //convert choice to access list variables
        int choiceChange = choice - 1;

        int pointsIncrease = _goals[choiceChange].RecordEvent();

        if (pointsIncrease != 0)
        {
            _score += pointsIncrease;
            Console.WriteLine($"Congratulations! You have earned {pointsIncrease} points!\nYou now have {_score} points.\n");
        }
        else{Console.WriteLine($"This goal is already acomplished\n");}
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        fileName = fileName + ".txt";

        using (StreamWriter fileOut = new StreamWriter(fileName))
        {
            fileOut.WriteLine("S," + _score.ToString());

            foreach(Goal goal in _goals)
            {
                fileOut.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        fileName = fileName + ".txt";

        _goals.Clear();

        string [] lines = System.IO.File.ReadAllLines(fileName);
     
        foreach (string line in lines)
        {
            string [] parts = line.Split(",");

            if (parts[0] == "S")
            {
                _score = int.Parse(parts[1]);
            }
            else if (parts[0] == "G")
            {
                SimpleGoal newSimpleGoal = new SimpleGoal(Convert.ToString(parts[1]), Convert.ToString(parts[2]), Convert.ToString(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(newSimpleGoal);
            }
            else if (parts[0] == "E")
            {
                EternalGoal newEternalGoal = new EternalGoal(Convert.ToString(parts[1]), Convert.ToString(parts[2]), Convert.ToString(parts[3]));
                _goals.Add(newEternalGoal);
            }
            else if (parts[0] == "C")
            {
                ChecklistGoal newChecklistGoal = new ChecklistGoal(Convert.ToString(parts[1]), Convert.ToString(parts[2]), Convert.ToString(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(newChecklistGoal);
            }

        }
    }
}
