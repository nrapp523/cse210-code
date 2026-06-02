using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment myAssignment = new WritingAssignment("Nick", "Rhetorical Methods", "Rhetorical Analysis of Conference Talk.");
        Console.WriteLine(myAssignment.GetWritingInformation());
    }
}