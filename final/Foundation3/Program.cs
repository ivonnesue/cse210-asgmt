using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine();

        Console.WriteLine("Marketing Messages: ");
        Console.WriteLine();
        
        //Event1
        Lectures lecture = new Lectures("Les Brown", "Lecture", 300);
        lecture.setEventTitle("Master the Mic");
        lecture.setDescription("Les Brown will bring out the world class" +
        "speaker in you, by showing you how to Master the Mic.");
        lecture.setEventDate("February 25th - 26th");
        lecture.setTime("10 AM - 12 PM");
        lecture.setAddress("BYU-Idaho Conference Center, \n210 West 4th South Rexburg, ID, 83460 ");
        lecture.DisplayMessages();

        //Event2

        //Event3

    }
}