using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
public class SectionManager
{
    private List<Section> _sections = new List<Section>();
    public SectionManager()
    {

    }
    public void Start()
    {
        //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        {
            Console.Clear();
            string welcome = "\n" +
            "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" + 
            "  This Program Calculate the Normal Height of a Tipical Section\n" +
            "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" ;
            Console.Write(welcome);
            int choice = -1;
            while (choice != 7)
            {

                string menu = "\n" +
                "Menu Options:\n" +
                "  1. Load Sections\n" +
                "  2. Save Sections\n" +
                "  3. Create Section\n" +
                "  4. Display Sections\n" +
                "  5. Display Results\n" +
                "  6. Record Results\n" +
                "  7. Quit\n" +
                "Select a choice from the menu: ";

                Console.Write(menu);

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    LoadSection();
                }
                else if (choice == 2)
                {
                    SaveSections();
                }
                else if (choice == 3)
                {
                    CreateSection();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Display Sections\n");
                    foreach (Section section in _sections)
                    {
                        Console.WriteLine(section.GetStringRepresentation());
                    }
                    Console.WriteLine();
                }
                else if (choice == 5)
                {
                    DisplayResults();
                }
                else if (choice == 6)
                {
                    RecordResults();
                }
                else if (choice == 7)
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
    void SaveSections()
    {
        Console.WriteLine("What is the filename?:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Section, Flow, Bottom Width, Section Slope, Slope, Material, Radius");
            foreach (Section section in _sections)
            {
                //separate by |
                //allow write with commas and save as .csv
                outputFile.WriteLine(section.GetStringRepresentation());
            }
        }
    }
    void LoadSection()
{
        //clear List
        Console.WriteLine("What is the filename?:");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines.Skip(1))
            {
                string[] parts = line.Split(",");
                //Section, Flow, Bottom Width, Section Slope, Slope, Material, Radius
                if (parts[0] == "Rectangular")
                {
                    double flow = double.Parse(parts[1]);
                    double bottomWidth = double.Parse(parts[2]);
                    double slope = double.Parse(parts[4]);
                    string material = parts[5];

                    Rectangular rectangular = new Rectangular(flow, bottomWidth, slope, material);
                    _sections.Add(rectangular);
                }
                else if (parts[0] == "Trapezoidal")
                {
                    double flow = double.Parse(parts[1]);
                    double bottomWidth = double.Parse(parts[2]);
                    double sectionSlope = double.Parse(parts[3]);
                    double slope = double.Parse(parts[4]);
                    string material = parts[5];

                    Trapezoidal trapezoidal = new Trapezoidal(flow, bottomWidth, sectionSlope, slope, material);
                    _sections.Add(trapezoidal);
                }
                else if (parts[0] == "Triangular")
                {
                    double flow = double.Parse(parts[1]);
                    double sectionSlope = double.Parse(parts[3]);
                    double slope = double.Parse(parts[4]);
                    string material = parts[5];

                    Triangular triangular = new Triangular(flow, sectionSlope, slope, material);
                    _sections.Add(triangular);
                }
                else if (parts[0] == "Circular")
                {
                    double flow = double.Parse(parts[1]);
                    double slope = double.Parse(parts[4]);
                    string material = parts[5];
                    double radius = double.Parse(parts[6]);
                    Circular circular = new Circular(flow, radius, slope, material);
                    _sections.Add(circular);

                }
                else if (parts[0] == "RoadSection")
                {
                    double flow = double.Parse(parts[1]);
                    double roadSlope = double.Parse(parts[3]);
                    double slope = double.Parse(parts[4]);
                    string material = parts[5];

                    RoadSection roadSection = new RoadSection(flow, roadSlope, slope, material);
                    _sections.Add(roadSection);

                }

            }
        }
            else
        {
            Console.WriteLine("File not found");
        }
    }
    void CreateSection()
    {
        Console.WriteLine("CreateSection Method running\n");
        int sectionChoice = -1;

        while (sectionChoice != 6)
        {
            string sectionMenu = "\n" +
            "Select the Setion:\n" +
            "  1. Rectangular\n" +
            "  2. Trapezoidal\n" +
            "  3. Triangular\n" +
            "  4. Circular\n" +
            "  5. Road Section\n" +
            "  6. Return to menu";

            Console.WriteLine(sectionMenu);
            sectionChoice = int.Parse(Console.ReadLine());
            if (sectionChoice == 1)
            {
                Console.Write("Enter Flow (m3/s): ");
                double flow = double.Parse(Console.ReadLine());
                Console.Write("Enter Bottom Width (m): ");
                double bottomWidth = double.Parse(Console.ReadLine());
                Console.Write("Enter Slope (m/m): ");
                double slope = double.Parse(Console.ReadLine());
                Console.Write("Type the Material (Concrete/HDPE/Steel/Asphalt/Terrain): ");
                string material = Console.ReadLine();
                Rectangular rectangular = new Rectangular(flow, bottomWidth, slope, material);
                _sections.Add(rectangular);
            }
            else if (sectionChoice == 2)
            {
                Console.Write("Enter Flow (m3/s): ");
                double flow = double.Parse(Console.ReadLine());
                Console.Write("Enter Bottom Width (m): ");
                double bottomWidth = double.Parse(Console.ReadLine());
                Console.Write("Enter Section Slope (m/m): ");
                double sectionSlope = double.Parse(Console.ReadLine());
                Console.Write("Enter Slope (m/m): ");
                double slope = double.Parse(Console.ReadLine());
                Console.Write("Type the Material (Concrete/HDPE/Steel/Asphalt/Terrain): ");
                string material = Console.ReadLine();
                Trapezoidal trapezoidal = new Trapezoidal(flow, bottomWidth, sectionSlope, slope, material);
                _sections.Add(trapezoidal);
            }
            else if (sectionChoice == 3)
            {
                Console.Write("Enter Flow (m3/s): ");
                double flow = double.Parse(Console.ReadLine());
                Console.Write("Enter Section Slope (m/m): ");
                double sectionSlope = double.Parse(Console.ReadLine());
                Console.Write("Enter Slope (m/m): ");
                double slope = double.Parse(Console.ReadLine());
                Console.Write("Type the Material (Concrete/HDPE/Steel/Asphalt/Terrain): ");
                string material = Console.ReadLine();
                Triangular triangular = new Triangular(flow, sectionSlope, slope, material);
                _sections.Add(triangular);
            }
            else if (sectionChoice == 4)
            {
                Console.Write("Enter Flow (m3/s): ");
                double flow = double.Parse(Console.ReadLine());
                Console.Write("Enter Radius (m): ");
                double radius = double.Parse(Console.ReadLine());
                Console.Write("Enter Slope (m/m): ");
                double slope = double.Parse(Console.ReadLine());
                Console.Write("Type the Material (Concrete/HDPE/Steel/Asphalt/Terrain): ");
                string material = Console.ReadLine();
                Circular circular = new Circular(flow, radius, slope, material);
                _sections.Add(circular);
            }
            else if (sectionChoice == 5)
            {
                Console.Write("Enter Flow (m3/s): ");
                double flow = double.Parse(Console.ReadLine());
                Console.Write("Enter Road Slope (m/m): ");
                double sectionSlope = double.Parse(Console.ReadLine());
                Console.Write("Enter Slope (m/m): ");
                double slope = double.Parse(Console.ReadLine());
                Console.Write("Type the Material (Concrete/HDPE/Steel/Asphalt/Terrain): ");
                string material = Console.ReadLine();
                RoadSection roadSection = new RoadSection(flow, sectionSlope, slope, material);
                _sections.Add(roadSection);
            }
            else if (sectionChoice == 6)
            {

            }
            else
            {
                Console.WriteLine("Select a valid option");
            }
        }
    }
    void DisplayResults()
    {
        Console.WriteLine("DisplayResults Method running\n");
        int i = 1;
        foreach (Section section in _sections)
        {
            Console.WriteLine($"Section N°{i} {section}: ");
            Console.WriteLine(section.DisplayResults());
            i += 1;
        }
    }
    void RecordResults()
    {
        Console.WriteLine("What is the filename?:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int i = 1;
            foreach (Section section in _sections)
            {
                outputFile.WriteLine($"Section N°{i}: ");
                //separate by |
                //allow write with commas and save as .csv
                outputFile.WriteLine(section.DisplayResults());
                i += 1;
            }
        }
    }
}