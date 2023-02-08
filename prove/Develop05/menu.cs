using System;

class Menu
{
    private List <string> mainMenu, goalMenu;

    private int mainMenuSelection;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "Menu Options: ",
            " 1. Creat New Goal",
            " 2. List Goals",
            " 3. Save Goals",
            " 4. Load Goals",
            " 5. Record Event",
            " 6. Quit"
        };

        goalMenu = new List<string>
        {
            " Types of Goal: ",
            " 1. Simple Goal",
            " 2. Eternal Goal", 
            " 3. Checklist Goal"
        };
    }
    public void DisplayMainMenu()
    {
        foreach (string menuitem in mainMenu)
        {
            Console.WriteLine(menuitem);
        }
    }
    
    public void DisplayPoints(int _totalPoints)
    {
        Console.WriteLine(string.Format("You have {0 points. \n}", _totalPoints));
    }

    public int DisplayGetMainMenu()
    {
        Console.WriteLine("select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayGetCreateNewGoal()
    {
        foreach (string menuitem in goalMenu)
        {
            Console.WriteLine(menuitem);
        }
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }


}
