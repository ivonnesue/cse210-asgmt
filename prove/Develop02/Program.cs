using System;
using System.IO;
using System.Text;

class Program
{
    Entry entry = new Entry();
    Journal journal = new Journal();

    //PromptGenerator prompts = new PromptGenerator();
    public void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Welcome to the Journal Program");

        Console.WriteLine("Please select one of the folloing choices: ");

        Console.WriteLine("1. Write \n2. Display  \n3. Load \n4. Save \n5. Quit \nWhat would you like to do?");
        int option = int.Parse(Console.ReadLine());
         
        int userOption = -1;


        while (userOption != 5)
        {
            if (userOption == 1)
            {
            Random randomPrompts = new Random();
            
            journal.WriteEntry();

            }
            else if (userOption == 2)
            {
            entry.ShowEntry();
            }
            else if (userOption == 3)
            {
            journal.loadfile();
            }   
            else if (userOption == 4)
            {
            journal.Savefile();
            journal.setFilename();
            }

            else
            {
                Console.WriteLine("Thank you for using the Journal Program");
            }
        }
       
    }
}
//use get entry method