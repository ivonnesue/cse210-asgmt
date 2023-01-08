using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade); //convert answer to integer

        
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (grade >=60)
        {
            Console.WriteLine("Your grade is D");
        }
        else 
        {
            Console.WriteLine("Your grade is F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed");
        }
        
        else
        {
            Console.WriteLine("You will do better next time.");
        }

    }   
}