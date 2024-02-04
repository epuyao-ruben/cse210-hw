using System;
using System.ComponentModel;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity()
    {

    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        //_duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"This activity will help you {_description}.");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void ShowSpinner(int spinnerDuration)
    {
        List<string> animamationString = new List<string>() {"|","/","-","\\",};
        int i = 0;
        while (spinnerDuration > i)
        {
            foreach (string s in animamationString)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            i++;
        }


    }
    public void ShowCountDown(int seconds)
    {
        for (int i=seconds; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}