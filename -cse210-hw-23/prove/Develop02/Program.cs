using System;

class Program
{
    static void Main(string[] args)
    {
        // create user menu
        // switch statment for user input
        // While user input is not 5 

        Journal journal = new Journal();
        int menuUserinput = 0;

        List<string> menu = new List<string>
        {
            "Please select one of the following choices:",
            "1.Write",
            "2.Display",
            "3.Load",
            "4.Save",
            "5.Quit",
        };
    while (menuUserinput != 5)
    {
        foreach(string menuItem in menu)
        {
            Console.WriteLine(menuItem);
        }
        menuUserinput =int.Parse(Console.ReadLine());
    }
    }
}