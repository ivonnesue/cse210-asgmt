using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();

        Running running1 = new Running(10, 40);
        

        
        Swimming swimming1 = new Swimming(8, 30);
        

        Cycling cycling1 = new Cycling(0.215, 2000.0, 60);

        List<Activity>SummaryList = new List<Activity>();
        //add to list
        
    
            SummaryList.Add(running1);
            SummaryList.Add(swimming1);
            SummaryList.Add(cycling1);
            //SummaryList.Add(activityType);
    

        foreach (Activity activity in SummaryList)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}