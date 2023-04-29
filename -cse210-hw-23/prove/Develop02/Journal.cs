using System;

class Journal
{
    List<Entries> entries;

    public Journal()
    {
        entries= new List<Entry>();
    }
    
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntries()
    {

    }

    public void SaveToCSV()
    {

    }

    public void LoadFromCSV()
    {
        
    }


    }

internal class Entry
{
}