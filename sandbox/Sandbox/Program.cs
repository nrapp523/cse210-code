using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;


class Program
{
  
    static void Main(string[] args)
    {
      /*  
      for (int i = 0; i < 20; i++)
      {
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b");
      }
      */
      Console.CursorVisible = false;
      int sleepTime = 250;
      string animationString = "\\|/";
      DateTime now = DateTime.Now;
      DateTime endTime = now.AddSeconds(3);
      int index = 0;
      while(DateTime.Now < endTime)
      {
        Console.Write(animationString[index++ % animationString.Length]);
        Thread.Sleep(sleepTime);
        Console.Write("\b");
      }
      Console.CursorVisible = true;
    }  

}