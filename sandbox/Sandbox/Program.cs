using System;
using System.Collections.Generic;
using System.ComponentModel;


class Program
{
    static void TestPass(out int x)
        {
            x = 30;
        }
    static void Main(string[] args)
    {
        int x = 10;
        TestPass(out x);
        Console.WriteLine(x);

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
        m
        
        
    }  

}