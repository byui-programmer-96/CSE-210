using System;

class Program
{
    static void Main(string[] args)
    { 
        Journal journal =new Journal();
       int userInput = 0;
    

        List <string> menu = new List<string>
        {
            "Please select an Option:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do?"

        };
        while (userInput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
        }
    }
      
}