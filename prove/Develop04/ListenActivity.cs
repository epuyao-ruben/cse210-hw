using System;
public class ListingActivity : Activity
{
    //private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity() : base("Reflecting Activity", "felect on times in ypur life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        DisplayStartingMessage();
    }
}