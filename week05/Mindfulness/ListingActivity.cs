using System;
using System.ComponentModel;
using System.Net;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        
        GetRandomPrompt();
        
        Console.Write("You may begin in: ");
        
        ShowCountDown();

        GetListFromUser();

        Console.WriteLine("You listed " + _count + " items!");

        DisplayEndingMessage();

        _prompts.Clear();
    }

    public void GetRandomPrompt()
    {
        Random numberRandom = new Random();
        int number = numberRandom.Next(0, _prompts.Count());
        Console.WriteLine("\t--- " + _prompts[number] + " ---");
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        List<string> _listFromUser = new List<string>();

        Console.WriteLine("");

        for (int count = 1; DateTime.Now <= endTime; count++)
        {
            Console.Write($"{count}. --- ");
            string addToList = Console.ReadLine();
            _listFromUser.Add(addToList);
        }

        _count = _listFromUser.Count();

        return _listFromUser;
    }
}