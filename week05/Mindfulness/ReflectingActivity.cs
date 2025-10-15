using System;
using System.Diagnostics;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
         //Adding Prompts to list
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //Adding questions to list
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DisplayQuestions();

        DisplayEndingMessage();

        _prompts.Clear();

        _questions.Clear();
    }

    public void GetRandomPrompt()
    {
        Random numberRandom = new Random();
        int number = numberRandom.Next(0, _prompts.Count());
        Console.WriteLine("\t---- " + _prompts[number] + " ----");
    }

    public void GetRandomQuestion()
    {
        if(_questions.Count() > 0)
        {
            Random numberRandom = new Random();
            int number = numberRandom.Next(0, _questions.Count());
            Console.Write("\t-- " + _questions[number]);
            _questions.Remove(_questions[number]);
        }
        else
        {
            Console.WriteLine("\nSorry no more questions.");
        }
        
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n\n");

        GetRandomPrompt();

        Console.WriteLine("When you have something in mind, press any key to continue\n");

        Console.ReadKey();

        Console.Write("Now ponder on each of the following questions as they relate to this experience.\nYou may being in: ");
        ShowCountDown(5);

        Console.Clear();
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now <= endTime)
        {
            GetRandomQuestion();
            ShowSpinner();
            Console.WriteLine("\n");
        }
    }
}