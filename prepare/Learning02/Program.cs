using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Graphic Designer";
        job1._company = "Microsoft";
        job1._startYear = 2019; //numbers in between " " are stored as string variables. Not needed at this point.
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job 3 for person 2
        Job job3 = new Job();
        job3._jobTitle = "Graphic Designer";
        job3._company = "PostNet";
        job3._startYear = 2017;
        job3._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Resume myResume2 = new Resume();
        myResume2._name = "Ivonne Ramos";
       
        myResume2._jobs.Add(job3);
    

        myResume.Display();

        myResume2.Display();
    }
}