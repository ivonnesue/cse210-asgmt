using System;
//Resume class

public class Resume
{
    public string _name;
    //create new list example = public List<classname>_category = new List<classname>()
    public List<Job> _jobs = new List<Job>();
    //ask how to add items to list. 
    //._jobs.Add("Software Engineer") caused an error
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }



}