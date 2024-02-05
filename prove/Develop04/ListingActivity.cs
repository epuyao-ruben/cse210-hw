using System;
using System.Diagnostics;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _userResponses = new List<string>();
    public ListingActivity() : base("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
    }
    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following  prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        int limitTime = _duration*1000;
        while (timer.ElapsedMilliseconds < limitTime)
        {
            GetListFromUser();
            _count += 1; 
        }
        timer.Stop();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }
            
    public void GetRandomPrompt()
    {
        Random index = new Random();
        int randomPos = index.Next(_prompts.Count);
        string randomPrompt = _prompts[randomPos];
        Console.WriteLine($" --- {randomPrompt} --- "); 
    }
    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        _userResponses.Add(Console.ReadLine());
        return _userResponses;
    }
}