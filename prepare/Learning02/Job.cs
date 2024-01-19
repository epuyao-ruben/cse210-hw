using System;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _starYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_starYear}-{_endYear}");
    }

}