using System;
using System.Diagnostics;
using System.Collections.Generic;    
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity() : base("Reflection Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }
    public void Run()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        int limitTime = _duration*1000; 

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            while (timer.ElapsedMilliseconds < limitTime)
            {
                DisplayQuestion();
                do
                {  
                    ShowSpinner(3);
                    Console.WriteLine();
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter);
                Console.WriteLine();    
            }
            timer.Stop();
            Console.WriteLine();
        }   
    }

    public string GetRandomPrompt()
    {
        Random index = new Random();
        int randomPos = index.Next(_prompts.Count);
        string randomPrompt = _prompts[randomPos];
        return randomPrompt; 
    }
    public string GetRandomQuestion()
    {
        if (_questions.Count > 0)
        {
            Random index = new Random();
            int randomPos = index.Next(_questions.Count);
            string randomPrompt = _questions[randomPos];        
            _questions.Remove(_questions[randomPos]);                   //delete current question to avoid repeating
            return randomPrompt;
        }
        else {
            return "You have answered all the questions!";
        }       
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }
    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}