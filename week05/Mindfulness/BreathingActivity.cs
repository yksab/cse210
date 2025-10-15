using System;
using System.Net;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now <= endTime)
        {
            Random random = new Random();
            int number = random.Next(4, 7);

            Console.WriteLine("\nbreath in...");
            ShowCountDown(number);

            Console.WriteLine("\nbreath out ...");
            ShowCountDown(number);
        }

        DisplayEndingMessage();
    }
}