using System;
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you make any new friends? if yes, who?",
        "Did today's activities contribute to your goals?",
        "What was something exciting you did today?",
        "Anyone dear whose birthday is today? if yes, who?",
        "Consider your life. Are you living a fulfilling life?",
    };
    public string _randomPrompt;

    public void RandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);

        _randomPrompt = prompts[index];
    }
}