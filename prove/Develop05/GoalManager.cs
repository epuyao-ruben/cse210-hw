using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }
    public void Start()
    //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        Console.Clear();
        int choice = -1;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            string menu = "\n" +
            "Menu Options:\n" +
            "  1. Create New Goal\n" +
            "  2. List Goals\n" +
            "  3. Save Goals\n" +
            "  4. Load Goals\n" +
            "  5. Record Event\n" +
            "  6. Quit\n" +
            "Select a choice from the menu: ";

            Console.Write(menu);

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Good bye!");
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Select a valid option");
            }
        }

        void DisplayPlayerInfo()
        //Displays the players current score.
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
        }
        void ListGoalNames()
        //Lists the names of each of the goals.
        {
            string goalNames =
                "  1. Simple Goal\n" +
                "  2. Eternal Goal\n" +
                "  3. Checklist Goal\n";

            Console.WriteLine(goalNames);

        }
        void ListGoalDetails()
        //Lists the details of each goal (including the checkbox of whether it is complete).
        {
            Console.WriteLine("The goals are:");
            if (_goals.Count > 0)
            {
                int i = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                    i += 1;
                }
            }
            else
            {
                Console.WriteLine();
            }

        }
        void CreateGoal()
        //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        {
            Console.WriteLine("The type of goals are: ");
            ListGoalNames();
            Console.Write("Which type of goal would you like to create? ");
            int typeSelection = int.Parse(Console.ReadLine());
            if (typeSelection == 1)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                //Console.WriteLine(simpleGoal.GetStringRepresentation());
            }
            else if (typeSelection == 2)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (typeSelection == 3)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
            }
            else
            {
                Console.WriteLine("Select a valid option");
            }

        }
        void RecordEvent()
        //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        {
            // ListGoalNames();
            // Console.Write("Which goal did you accomplish? ");
            // int recordSelection = int.Parse(Console.ReadLine());
            // if (_goals[recordSelection].GetType == "SimpleGoal")
            // {

            // }


        }
        void SaveGoals()
        {

        }
        void LoadGoals()
        {

        }
    }
}


