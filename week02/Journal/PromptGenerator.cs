using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        _prompts.Add("What was the best thing you did today?");
        _prompts.Add("Did you learn anything new today?");
        _prompts.Add("Did you do something different today?");
        _prompts.Add("How is your scripture reading?");
        _prompts.Add("Did you bless someones life today?");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 4);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }
}