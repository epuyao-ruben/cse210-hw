using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is your magic number? ");
        //string userMagic = Console.ReadLine();
        //int magicNumber = int.Parse(userMagic);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
        
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }


    }
}