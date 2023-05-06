using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>();
        prompts.Add("What was the best thing that happened today?");
        prompts.Add("What was the worst thing that happened today?");
        prompts.Add("What was the most challenging thing I faced today?");
        prompts.Add(" What did I learn today?");
        prompts.Add("What did I do today that I am proud of?");

    }

    public string GetRandomPRompt()
    {
        Random random = new Random();
        int numberPrompts = random.Next(prompts.Count);
        string randomPrompt = prompts[numberPrompts];
        Console.WriteLine(randomPrompt);
        return randomPrompt;
    }

    internal string GetRandomPrompt()
    {
        throw new NotImplementedException();
    }
}