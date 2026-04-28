using System;

class Program
{
    static void Main(string[] args)
    {
        //ask user for magic number and store it
        /*string magicNum;
        int magicNumInt;
        Console.Write("What is the magic number? ");
        magicNum = Console.ReadLine();
        magicNumInt = int.Parse(magicNum);
        */


        //loop until user guesses right
        int userGuessInt;
        int magicNum;
        //generate new random variable
        Random randomGenerator = new Random();
        magicNum = randomGenerator.Next(1, 100);
        int i = 0;
        do
        {

            i += 1;
            //take users response
            string userGuess;
            Console.Write("What is your guess? ");
            userGuess = Console.ReadLine();
            userGuessInt = int.Parse(userGuess);
            //conditional based on higher or lower
            if (userGuessInt > magicNum)
            {
                Console.WriteLine("Go Lower!");
            }
            else if(userGuessInt < magicNum)
            {
               Console.WriteLine("Go higher!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }

        } while (userGuessInt != magicNum);
        Console.WriteLine($"Completed in {i} attempts!")
        
    }   
}