using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        //var for selection or choice
        int selection = 1;

        while (selection != 5)
        {
            //show menu choice
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");

            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                theJournal.AddEntry();
            }

            else if (selection == 2)
            {
                theJournal.DisplayAll();
            }

            else if (selection == 3)
            {
                theJournal.LoadFromFile();
            }

            else if (selection == 4)
            {
                theJournal.SaveToFile();
            }

            else if (selection == 5)
            {
                Console.WriteLine("\nYou closed your Journal, googbye!\n");
                System.Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("\nPlease, select a valid option (1 - 5):");
            }   
        }   
    }
}