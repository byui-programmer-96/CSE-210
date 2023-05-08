using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heart and lean not",
        "understanding; in all thy ways acknowledge him, and he shall direct they paths.");
        string userInput = "";
        
        while (userInput != "quit" && scripture.HaswordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine(); 
            Console.ReadLine();
            scripture.Removewords();
        }
            
            
            
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine("Hopefully you memorized the scripture!")

    }
}