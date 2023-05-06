using System;
public class Entry
{
    public string _prompt;
    public string _date;
    public string _response;


    public Entry()
    {
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_response}");
    }
    public string GetEntryAsCSV()
    {
        string entry = $"{_date}|{_prompt}|{_response}";
        return entry;
    }
}
