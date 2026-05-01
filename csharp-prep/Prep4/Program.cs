using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, and type o when finished!");
        //variable for to determine runtime of do while loop
        bool isFinished = false;
        string userInput;
        int integerHolder;
        List<int> numList = new List<int>();
        
        //loop for retrieving user input
        do
        {
            
    

            Console.Write("Enter Number:");
            userInput = Console.ReadLine();
            integerHolder = int.Parse(userInput);
            if (integerHolder == 0)
            {
                isFinished = true;
            }
            else 
            {
                numList.Add(integerHolder);
            }
            

            
        } while (isFinished == false);
        
        Console.WriteLine($"The sum is: {numList.Sum()}");
        Console.WriteLine($"The average is: {numList.Average()}");
        Console.WriteLine($"The largest number is: {numList.Max()}");

    }
}