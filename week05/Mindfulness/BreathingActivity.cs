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
            int number = random.Next(3, 7);

            Console.Write("breath in...");
            ShowCountDown(number);

            Console.Write("breath out ...");
            ShowCountDown(number);
        }

        DisplayEndingMessage();
    }
}