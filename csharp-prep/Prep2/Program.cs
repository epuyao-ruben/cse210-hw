using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Your Grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your letter is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You pass the class!");
        }
        else 
        {
            Console.WriteLine("You don't pass the class, success on your next time!");
        }
    }
}