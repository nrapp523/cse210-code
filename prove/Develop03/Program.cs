using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scriptures myScripture = new Scriptures("For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");
        Reference myReference = new Reference("Moses", 1, 39);

        bool repeatLoop = true;

        void DisplayResults()
        {
            Console.Clear();
            Console.WriteLine(myReference.GetReference());
            Console.WriteLine(myScripture.GetVerse());
            Console.Write("Press enter to continue or q to quit.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
        }
        
        do
        {
            Console.Clear();
            Console.WriteLine(myReference.GetReference());
            Console.WriteLine(myScripture.GetVerse());
            Console.Write("Press enter to continue or q to quit.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if(keyInfo.Key == ConsoleKey.Enter)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (myScripture.GetIndexList().Count() > 0)
                    {
                        myScripture.CreateRandomIndex();
                        myScripture.ReplaceWord();
                        myScripture.UpdateVerse();
                    }
                    else
                    {
                        DisplayResults();
                        repeatLoop = false;
                        break;
                    }
                    
                }
            }
            else if (keyInfo.Key == ConsoleKey.Q)
            {
                repeatLoop = false;
            }


        } while (repeatLoop);

    }
}