using System;

class Program
{
    static void Main(string[] args)
    {
        //ask for grade percentage, convert to int, and store
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int letterPercentage = int.Parse(userInput);

        /*Conditional based on what letter percentage it falls in
        assign variable based off of where it falls */
        string letter;
        if (letterPercentage >= 90)
        {
            letter = "A";
        }
        else if (letterPercentage >= 80)
        {
            letter = "B";
        }
        else if (letterPercentage >= 70)
        {
            letter = "C";
        }
        else if (letterPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //determine grade sign
        string gradeSign;
        if (letterPercentage >= 90)
        {
            gradeSign = " ";
        }
        else if (letterPercentage < 60)
        {
            gradeSign = " ";
        }
        else
        {
            int percentageRemainder;
            percentageRemainder = letterPercentage % 10;
            if (percentageRemainder >= 7)
            {
                gradeSign = "+";
            }
            else if (percentageRemainder < 3)
            {
                gradeSign = "-";
            }
            else
            {
                gradeSign = " ";
            }
        }

        //print your letter grade
        Console.WriteLine($"Your grade is a(n) {letter}{gradeSign}");
        
        //determine if passed and print message
        if (letterPercentage >= 70)
        {
            Console.WriteLine("You passed, congrats!");
        }
        else
        {
            Console.WriteLine("You didn't quite pass this class, better luck next time");
        }
    }
}