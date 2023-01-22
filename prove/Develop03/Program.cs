using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference scriptureReference = new Reference("Proberbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while (userInput != "quite" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.ReadLine();

            scriptureMemorizer.removeWordsFromText();
        }

    }
}