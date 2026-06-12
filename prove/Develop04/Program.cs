using System;

class Program
{
    static void Main(string[] args)
    {
       Listing myListing = new Listing("This is a test");
       myListing.StartActivity();
       myListing.RunActivity();
       myListing.DisplayAmountOfItems();
       myListing.EndActivity();
    }
}