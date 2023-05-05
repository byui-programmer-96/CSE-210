class Journal 
{
    List<string> entries;

    public Journal()
    {
        entries = new List<Entry>{};
    }
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {

    }

    public void SaveToCVS()
    {

    }

    public void LoadFromCSV()
    {

    }