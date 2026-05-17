using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Prompt _prompt = new Prompt();
    public void AddEntry()
    {
        string prompt = _prompt.GetPrompt();

        Console.WriteLine($"\nPrompt: {prompt}");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = prompt;
        entry._response = response;
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveJournal()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._response}");
        }
    }
    Console.WriteLine("Journal saved.");
}
    public void LoadJournal()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded.");
        }
        else
        {
            Console.WriteLine("File does not exists.");
        }
    }
}