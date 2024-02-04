using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
        
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(2);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        ShowCountDown(3);
        Console.WriteLine();

        int i = 5;
        while (_duration > i)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            i += 10;
        }

        Console.WriteLine();


    }
}