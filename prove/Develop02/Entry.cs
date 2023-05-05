class Entries 
{
    string date, prompt, responses;

    public Entry(string _data, string _prompt, string _response)
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