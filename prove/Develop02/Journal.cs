using System;
using System.Collections.Generic;
using System.IO;
public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        //Write a new entry - Show the user a random prompt (from a list that you create)
        PromptGenerator prompt = new PromptGenerator();
        string promptText = prompt.GetRandomPrompt();
        Console.WriteLine(promptText);

        //save their response, the prompt, and the date as an Entry.
        Entry entry = new Entry();
        //response
        entry._entryText = Console.ReadLine();
        //prompt
        entry._promptText = promptText;
        //date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        entry._date = dateText;
        //add to _entries list in Journal
        _entries.Add(entry);        
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?(.txt or .csv):");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                //separate by |
                //allow write with commas and save as .csv
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
    _entries.Clear();
    Console.WriteLine("What is the filename?(.txt or .csv):");
    string fileName = Console.ReadLine();
 
        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                //add part from file to entries list
                Entry fileEntries = new Entry();
                fileEntries._date = parts[0];
                fileEntries._promptText = parts[1];
                fileEntries._entryText = parts[2];
                _entries.Add(fileEntries);
            }
        }
            
        else 
        {
            Console.WriteLine("File not found");
        }
    }
}