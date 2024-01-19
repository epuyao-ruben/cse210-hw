using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        //className variableName = new className()
        Job job1 = new Job();
        //variableName.variableMemberName = "data"
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._starYear = 2019;
        job1._endYear = 2022;
        //print company
        //Console.WriteLine(job1._company);
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._starYear = 2022;
        job2._endYear = 2023;

        //Console.WriteLine(job2._company);
        //job2.DisplayJobDetails();

        Resume resume = new Resume();
        resume._name = "Allison Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //display Test
        //Console.WriteLine(resume._jobs[0]._jobTitle);       

        resume.DisplayResume();

    }
}
