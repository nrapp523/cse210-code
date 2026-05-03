using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userStrNum = Console.ReadLine();
        int userNum = int.Parse(userStrNum);
        return userNum;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string birthYearStr = Console.ReadLine();
        birthYear = int.Parse(birthYearStr);
    }

    static int SquareNumber(int userNumInput)
    {
        return (int)Math.Pow(userNumInput, 2);
    }
    static void DisplayResult(string userName, int squaredNum, int userYear)
    {
        int userAge = 2026 - userYear;
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        Console.WriteLine($"{userName}, you will turn {userAge} this year");
    }

    
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squareNum = SquareNumber(UserNumber);
        DisplayResult(userName, squareNum, birthYear);

        
    }
}