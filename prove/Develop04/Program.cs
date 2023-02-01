using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine();

      

        //Console.WriteLine("1. Start Breathing Activity \n2. Start Reflecting Activity  \n3. Listing Activity \n4. Quit ");
        

        int userOption = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            " 1. Start Breathing Activity",
            " 2. Start Reflecting Activity",
            " 3. Start Listing Activity",
            "4. Quit"
        };

        while (userOption != 4)
        {
            Console.Clear();
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
                
            }
            Console.WriteLine("Choose a menu option");
            userOption = int.Parse(Console.ReadLine());
                
            switch (userOption)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingAct();
                break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.runReflectingActivity();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.runListingActivity();
                    
                    break;
            }
    
        }


    }




    
}