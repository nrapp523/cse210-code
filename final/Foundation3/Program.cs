using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("585 N 400 E");
        Event myEvent = new Event("Marriage", "This is a wedding", "September 25th", "5 PM", myAddress, "test");
        myEvent.GenerateStandardDetails();
    }
}