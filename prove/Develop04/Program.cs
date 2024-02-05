using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.WriteLine("Hello Develop04 World!");
            //Activity activity1 = new Activity("Breathing Activity", "select description", 30);
            int selection = -1;
            while (selection != 4)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1. Start breathing activity");
                Console.WriteLine("\t2. Start reflecting activity");
                Console.WriteLine("\t3. Start listing activity");
                Console.WriteLine("\t4. Quit");
                Console.WriteLine("Select a choice from the menu: ");

                selection = int.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                }
                else if (selection == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                }
                else if (selection == 3)
                {
                    ListingActivity listenActivity = new ListingActivity();
                    listenActivity.DisplayStartingMessage();
                    listenActivity.Run();
                    listenActivity.DisplayEndingMessage();
                }
                else if (selection == 4)
                {
                    Console.WriteLine("Good bye!");
                    System.Environment.Exit(0);
                }
                else 
                {
                    Console.WriteLine("Select a valid option");
                }
            }
        }
    }