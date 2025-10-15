using System;
using System.Globalization;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the " + _name + "Activity.\n");
        Console.WriteLine(_description + "\n");
        Console.Write("What is the durations (seconds) of your session activity? ");
        
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready ....");
        ShowSpinner();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine("You have completed " + _duration + " seconds of the " + _name + " Activitiy.");
        ShowSpinner();

        Console.Clear();
    }

    public void ShowSpinner(int seconds=5)
    {
        string[] _animationstring1 = new string[4] { "|", "\\", "-", "/" };
        string[] _animationstring2 = new string[6] { "A", "B", "C", "c", "b", "a" };
        string[] _animationstring3 = new string[2] { ":)", ";)" };
        string[] _animationstring4 = new string[4] { "Z", "ZZ", "ZZZ", "ZZ" };

        Random _random = new Random();
        string animationNumber = _random.Next(1, 5).ToString();
        string animationRandom = String.Concat("_animationstring", animationNumber);
        int animationCount = animationNumber.Count();

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(seconds);

        for(int i = 0; _startTime <= _endTime; i++)
        {
            Console.Write(animationRandom[i]);
            Thread.Sleep(1000);

            if (animationRandom == "_animationstring4")
            {
                for(int j = 0; j < animationCount; j++)
                {
                    Console.Write("\b \b");
                }
            }
            else if(animationRandom == "_animation3")
            {
                Console.Write("\b \b\b \b");
            }
            else
            {
                Console.Write("\b ");
            }
        }
    }

    public void ShowCountDown(int seconds=5)
    {

        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\br \br");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}