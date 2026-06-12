using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;

class Menu
{
    private string _menuString = """
    Menu Options:
        1. Start breathing activity
        2. Start reflecting activity
        3. Start listing activity
        4. Quit
    Select a choice from the menu:
    """;
    private string _userChoice;
    private bool _validInput = false;
    private bool _continueRunning = true;
    public void MenuInput()
    {
        Console.WriteLine(_menuString);
        _userChoice = Console.ReadLine();
        while(_validInput == false)
        {
            if (int.TryParse(_userChoice, out int testNumber))
            {
                _validInput = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That is the wrong input type");
                Console.WriteLine(_menuString);
                _userChoice = Console.ReadLine();
            }
        }

    }
    public void RunMenu()
    {
        while(_continueRunning)
        {
            MenuInput();
            if(_userChoice == "1")
            {
                Breathing breathingActivity = new Breathing("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.StartActivity();
                breathingActivity.RunActivity();
                breathingActivity.EndActivity();
            }
            else if(_userChoice == "2")
            {
                Reflection reflectionActivity = new Reflection("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.StartActivity();
                reflectionActivity.RunActivity();
                reflectionActivity.EndActivity();
                
            }
            else if(_userChoice == "3")
            {
                Listing listingActivity = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.StartActivity();
                listingActivity.RunActivity();
                listingActivity.DisplayAmountOfItems();
                listingActivity.EndActivity();
            }
            else if(_userChoice == "4")
            {
                _continueRunning = false;
                Console.Write("Quitting");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}

