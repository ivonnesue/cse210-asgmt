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
        Lectures lecture = new Lectures("Les Brown", 300);
        lecture.DefineAdditionalInfo();
        lecture.setAdditionInfo(lecture.DefineAdditionalInfo());

        lecture.setEventType("Lecture");
        lecture.setEventTitle("Master the Mic");
        lecture.setDescription("Les Brown will bring out the world class" +
        " speaker in you, by showing you how to Master the Mic.");

        lecture.setEventDate("February 25th - 26th");

        lecture.setTime("10 AM - 12 PM");
        lecture.setAddress("BYU-Idaho Conference Center, \n210 West 4th South Rexburg, ID, 83460 ");
        lecture.DisplayMessages();

        //Event2
        Console.WriteLine("-----------------------------------");

        Receptions reception = new Receptions("rsvp@receptionevent.com");
        reception.DefineAdditionalInfo();
        reception.setAdditionInfo(reception.DefineAdditionalInfo());
        
        reception.setEventType("Reception");
        reception.setEventTitle("Wedding of Mr. and Mrs. Doe");
        reception.setDescription("You're invited to the Wedding of Joe and Jane Doe");

        reception.setEventDate("April 15th, 2023");
        reception.setTime("5:00 PM - 9:00 PM");
        reception.setAddress("City Event Center \n125 A Street \nCityA, StateA ");

        reception.DisplayMessages();


        //Event3
        Console.WriteLine("-----------------------------------");

        OutdoorEvent outdoor = new OutdoorEvent("65 F - 75 F, Partly Cloudy, 0% chances of Rain"/*, 
        "Outdoor"*/);

        outdoor.DefineAdditionalInfo();
        outdoor.setAdditionInfo(outdoor.DefineAdditionalInfo());

        outdoor.setEventType("Outdoor Event");
        outdoor.setEventTitle("International Jazz Festival");
        outdoor.setDescription("The State's Biggest series of Jazz concerts" +
        "\nwith dozens of acclaimed artist from jazz and world music.");

        outdoor.setEventDate("April 15th - April 22th, 2023");
        outdoor.setTime("5:00 PM - 9:00 PM");
        outdoor.setAddress("Toyota Amphitheatre \n2677 Forty Mile Rd, \nWheatLand, California");
        
        outdoor.DisplayMessages();

    }
}