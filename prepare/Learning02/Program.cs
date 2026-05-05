using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "apple";
        job1._endYear = 2024;
        job1._startYear = 2012;
        job1._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._endYear = 2010;
        job2._startYear = 2004;
        job2._jobTitle = "Cyber Analyst";

     
        Resume myResume = new Resume();
        myResume._name = "Jacob";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        Console.WriteLine($"Name: {myResume._name}");
        Console.WriteLine("Jobs:");
        myResume.Display();
        



    }
}