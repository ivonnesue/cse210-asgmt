using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _PromptList, _PonderingList;
    

    //constructor//
    //public ReflectingActivity() : base(activityName, startMessage,
    //description, duration, endMessage)
    //{


    public ReflectingActivity() : base()
    {
        setActivityName("Reflection Activity");

        setDescription("reflect on times when you have" +
        "shown strenght and resilience. This wil help you recognzie the power you have" +
        "and how you can use it in other aspects of your life");

        _PromptList = new List<string>
        {
            "- Think of a time when you stood up for someone else.",
            "- Think of a time when you did something really difficult.",
            "- Think of a time when you helped someone in need.",
            "- Think of a time when you did something truly selfless."
        };

        _PonderingList = new List<string>
        {
            "- Why was this experience meaningful to you?",
            "- Have you ever done anything like this before?",
            "- How did you get started?",
            "- How did you feel when it was complete?",
            "- What made this time different than other times when you were not as successful?",
            "- What is your favorite thing about this experience?",
            "- What could you learn from this experience that applies to other situations?",
            "- What did you learn about yourself through this experience?",
            "- How can you keep this experience in mind in the future?"
        };
    }

        
        public string getRandomPrompt()
        {
            var randomPrompt = new Random();
            int index = randomPrompt.Next(_PromptList.Count());
            return _PromptList[index];

        }

        //public string getPonderingQ()
        //{
        //    var randomPQuestion = new Random();
        //    int index = randomPQuestion.Next(_PonderingList.Count);
        //    return _PonderingList[index];
        //}

        public void displayRandomPrompt()
        {
            Console.WriteLine("Consider the following: ");
            Console.WriteLine(getRandomPrompt());
            Console.WriteLine();

            Console.WriteLine("When you have something in mind, press enter to continue");
            Console.ReadLine();

            
        }

        public void displayPonderingQ()
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int randomInt = new Random().Next(0, _PonderingList.Count());
                while (indexes.Contains(randomInt))
                {
                    randomInt = new Random().Next(0, _PonderingList.Count());
                }
                indexes.Add(randomInt);
            }
            Console.WriteLine("Now ponder on each of the Following questions as" +
            "they relate to this experience");
            DisplayCountdown(5);

            foreach (int index in indexes)
            {
                Console.Write(_PonderingList[index]);
                showSpinner(getUserInputTime() /  indexes.Count());
                Console.WriteLine();

            }
            
        }

         public void runReflectingActivity()
        {
            runActivityParentStart();
            displayRandomPrompt();
            Console.WriteLine();

            displayPonderingQ();
            runActivityParentEnd();
            
        }
}   