using System;

class AllGoals
{
    private List<BaseGoal> allGoals = new List<BaseGoal>();
    private int totalPoints;

    public int getTotalPoints()
    {
        return totalPoints;
    }

    public void addGoal(BaseGoal _goal)
    {
        allGoals.Add(_goal);
    }

    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been loaded.");
        }
        foreach (BaseGoal goal in allGoals)
        {
            Console.WriteLine(goal.ToString());
        }

    }

    public void saveGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
        }

        string fileTosave = DisplayGetGoalsFile();

        List<string> saveGoals = new List<string>();
        saveGoals.Add(goal.ToCSVRecord());

        foreach (BaseGoal goal in allGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }

        FileHandling.SaveToCSV(saveGoals, fileTosave);

        Console.WriteLine("Goals saved. ");
                
    }

    public void LoadGoals() //string _filePath = "")
    {
        List<string> fileGoals;
        /*if (File.Exists(_filePath))
        {
            fileGoals = FileHandling.LoadFromCSV(_filePath);
        }
        else
        {*/
            fileGoals = FileHandling.LoadFromCSV(DisplayGetGoalsFile());
        
        //}
        BaseGoal goal = null;
        foreach(string goalInFile in fileGoals)
        {
            string[] goalParts = goalInFile.Split('|');
            int goalType = int.Parse(goalParts[0]);
            switch(goalType)
            {
                case 1:
                    goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), 
                        bool.Parse(goalParts[4]));
                        break;                
            }

            if (goal != null && allGoals.Contains(goal) == false)
            {
                allGoals.Add(goal);
            }
        }
        Console.WriteLine("\nGoals loaded.\n");
    }

    public string DisplayGetGoalsFile()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }

    public void DisplayGoalRecordEvent()
    {
        Console.WriteLine("The goals are: ");
        foreach (BaseGoal goal in allGoals)
        {
            Console.WriteLine(string.Format("{0} {1}", allGoals.IndexOf(goal) +1, goal.getGoalName()));

        }
        Console.WriteLine("Which goal did you accomplish? ");
        int recordEvent = int.Parse(Console.ReadLine()) -1;
        allGoals[recordEvent].RecordEvent();
        totalPoints += allGoals[recordEvent].getGoalPoints();

        Console.WriteLine(string.Format("You now have {0} points", totalPoints.ToString());

    }



    











}