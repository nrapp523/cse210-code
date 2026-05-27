using System;

class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new Reference("1 Nephi", 11, 12);
        Console.WriteLine(newReference.GetReference());
        newReference.SetReference("2 Nephi", 2, 25, 27);
        Console.WriteLine(newReference.GetReference());
    }
}