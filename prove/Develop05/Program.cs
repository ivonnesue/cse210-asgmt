using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            menu.DisplayPoints(allGoals.getTotalPoints());
            menu.DisplayGetMainMenu();
            userMainMenuSelection = menu.DisplayGetMainMenu();

            switch (userMainMenuSelection)
            {
                case 1:
                    int creatNewGoalSelection = menu.DisplayGetCreateNewGoal();
                    BaseGoal goal = null;
                    switch (creatNewGoalSelection)
                    {
                        case 1: 
                        goal = new SimpleGoal();
                        goal.askforGoalName();
                        goal.askForDescription();
                        goal.askForPoints();
                        break;
                
                        case 2: 
                        goal = new EternalGoal();
                        goal.askforGoalName();
                        goal.askForDescription();
                        goal.askForPoints();
                        break;

                        case 3: 
                        goal = new Checklist();
                        goal.askforGoalName();
                        goal.askForDescription();
                        goal.askForPoints();
                        goal.DisplayGetFrequencyAmount();
                        goal.DisplayGetBonusPoints();
                        break;
                
                    }
                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }

                    break;
                
                case 2:
                    allGoals.DisplayGoals();
                    break;
                case 3:
                    allGoals.saveGoals();
                    break;
                case 4:
                    allGoals.LoadGoals();
                    break;
                case 5:
                    allGoals.DisplayGoalRecordEvent();
                    break;
            }

        }
    }
}