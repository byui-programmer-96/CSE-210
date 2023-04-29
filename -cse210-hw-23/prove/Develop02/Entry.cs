class Entries
{
    string date, prompt, response;

    public Entries(string _date, string _prompt,string _response)
    {

    }
    public void DisplayEntries()
    {

    }
    public string getEntriesAsCVS()
    {
        return string.Format("{0}|{1}|{2}", date, prompt,response);
    }
}