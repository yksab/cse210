using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Describe the best thing you did today?");
        _prompts.Add("Tell about anything new you learned today?");
        _prompts.Add("What did you do that was different today?");
        _prompts.Add("How did the spirit teach you during your scripture reading?");
        _prompts.Add("What can you do to bless someones life today?");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 4);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }
}