using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3,2);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        
        Random random = new Random();
        Fraction fraction4 = new Fraction();
        for (int i = 0; i<20; i++)
        {
            int topNum = random.Next(1,100);
            int bottomNum = random.Next(1,100);
            fraction4.SetTop(topNum);
            fraction4.SetBottom(bottomNum);
            Console.Write($"Fraction {i+1}: ");
            Console.Write($"string: {fraction4.GetFractionString()} ");
            Console.WriteLine($"Number: {fraction4.GetDecimalValue()}");

        }



    }
   
}