internal class Entry
{
    internal string _prompt;
    internal string _date;

    public Entry()
    {
    }

    internal void DisplayEntry()
    {
        throw new NotImplementedException();
    }
}
class Entries 
{
    private readonly object response;
    string date, prompt, responses;

    public Entries(string _data, string _prompt, string _response)
    {

    }
    public void DisplayEntry()
    {

    }

    public string getEntryAsCSV()
    {
        return string.Format("(0)|(1)|(2)", date, prompt, response);
    }
}