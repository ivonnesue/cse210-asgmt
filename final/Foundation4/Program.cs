using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();

        Running running1 = new Running(10, 40);
        //Console.WriteLine(running1.GetSummary());

        
        Swimming swimming1 = new Swimming(8, 30);
        //Console.WriteLine(swimming1.GetSummary());

        List<Activity>SummaryList = new List<Activity>();
        //add to list
        
    
            SummaryList.Add(running1);
            SummaryList.Add(swimming1);
            //SummaryList.Add(activityType);
    

        foreach (Activity activity in SummaryList)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}