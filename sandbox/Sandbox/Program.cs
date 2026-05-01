using System;
using System.Collections.Generic;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        //This is super cool//
       /* Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is crazy");
        */
       /* for(int i=0; i <= 100; ++i)
        {
            int powerNumber = (int)Math.Pow(i, 2);
            Console.WriteLine($"Two to the power of {i}, is {powerNumber}");
            Console.WriteLine($", 0x{powerNumber.ToString("X")}");
        }*/
        /*List<int> myData = new List<int>();
        myData.Add(1);
        myData.Add(2);
        foreach(int i in myData)
        {
            Console.WriteLine(i);
        }
        */
        static void DisplayGreeting()
        {
            Console.WriteLine("hello betty");
        }
        DisplayGreeting();
        static double AddNumbers(int n1, int n2, double n3)
        {
            double total = n1 + n2 + n3;
            return total;
        }
        double total = AddNumbers(10,20,30.0);
        Console.WriteLine(total);
    }  

}