using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while (userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString())); 
            Console.WriteLine();
            Console.WriteLine("type quit if you want to exit");
            userInput = Console.ReadLine();
            if (scriptureMemorizer.hasWordsLeft() == true)
                {
                    scriptureMemorizer.removeWordsFromText();
                }

        }
    }
}