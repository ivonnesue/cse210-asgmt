using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number, type 0 when finished. Press enter to continue");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            //add numbers to list if answer is not 0

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        /// iterate through the list
        Console.WriteLine("Your list is:");
        for (int i = 0; i < numbers.Count(); i++)
        {
            Console.WriteLine(numbers[i]);
        }

        /// sum items in the list
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum of your list is: {total}");

        /// find the average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}