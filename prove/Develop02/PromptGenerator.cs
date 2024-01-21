using System;
using System.Collections.Generic;
public class PromptGenerator
{
    //Crear la lista que contiene strings (oraciones con preguntas para agregar al diario)
    public static string[] _promptsBase = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today?",
        "How did I show gratitude today?",
        "What were some challenges I faced today and how did I overcome them?",
        "What did I do to help others today?",
        "What did I do today that made me proud of myself?",
        "What are some things I would like to do differently tomorrow?",
        "What are some things I am looking forward to tomorrow?",
        "What are some things I want to remember about today?"
    };
    public List<string> _prompts = new List<string>(_promptsBase);

    public string GetRandomPrompt()
    {
        Random index = new Random();
        int randomPos = index.Next(_prompts.Count);
        string randomPrompt = _prompts[randomPos];
        return randomPrompt; 
    }
}
