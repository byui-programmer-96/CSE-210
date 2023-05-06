using System;
using System.IO;
using System.Collections.Generic;

public class Journal 
{
    List<string> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void DisplayJournalEntry()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {
        PromptGenerator getPrompt = new PromptGenerator();
        string prompt = getPrompt.GetRandomPrompt();
        Dateline date = Dateline.Now;
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        string entryResponse = Console.WriteLine();
        Entry newEntry = new Entry();
        newEntry._prompt = prompt;
        newEntry._date = entryResponse;
        _entries.Add(newEntry);
            Console.WriteLine();
        return;
    }

    public void SaveToCVS()
    {

    }

    public void LoadFromCSV()
    {

    }

    private class Dateline
    {
        public static Dateline Now { get; internal set; }
    }
}

internal class _entries
{
    internal static void Add(Entry newEntry)
    {
        throw new NotImplementedException();
    }
}