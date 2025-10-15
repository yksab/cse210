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
        Console.WriteLine("\nWell done!!");
        ShowSpinner();
        Console.WriteLine("\nYou have completed " + _duration + " seconds of the " + _name + ".");
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
        string animationRandom = _random.Next(1, 5).ToString();
        string animationWord = String.Concat("_animationstring", animationRandom);

        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(seconds);

        int i;
        int timer = 250;

        for(i = 0; DateTime.Now <= _endTime; i++)
        {
            Thread.Sleep(timer);

            if(animationWord == "_animationstring1")
            {
                Console.Write(_animationstring1[i]);
                Thread.Sleep(timer);

                if(i == 3)
                {
                    i=-1;
                    Console.Write("\b \b");
                }
                else
                {
                    Console.Write("\b \b");
                } 
            }
            else if(animationWord == "_animationstring2")
            {
                Console.Write(_animationstring2[i]);
                Thread.Sleep(timer);

                if(i == 5)
                {
                    i = -1; 
                    Console.Write("\b \b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
            else if(animationWord == "_animationstring3")
            {
                Console.Write(_animationstring3[i]);
                Thread.Sleep(timer);

                if(i == 1)
                {
                    i = -1;
                    Console.Write("\b\b  \b\b");
                }
                else
                {
                    Console.Write("\b\b  \b\b");
                }   
            }
            else if (animationWord == "_animationstring4")
            {
                Console.Write(_animationstring4[i]);
                Thread.Sleep(timer);

                switch (i)
                {
                    case 0 : Console.Write("\b \b"); break;
                    case 1 : Console.Write("\b\b  \b\b"); break;
                    case 2 : Console.Write("\b\b\b   \b\b\b"); break;
                    case 3 : Console.Write("\b\b  \b\b"); i = -1; break;
                }
            }
        }
    }

    public void ShowCountDown(int seconds=5)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}