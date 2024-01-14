using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Creating list
        List<int> numbers = new List<int>();

        //initial value for usernumber and run the loop
        int userNumber = -1;

        while(userNumber != 0)
        {
            Console.Write("Enter a number, type 0 when finished. ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        //average
        //number is float, so we need change sum type data
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //largest value
        int max = numbers[0];

        //found in every value and keep the largest
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}
