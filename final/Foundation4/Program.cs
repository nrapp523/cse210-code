using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Running myRunning = new Running("October 6th, 2025", 20, 2);
        Bicycle myBiking = new Bicycle("January 1st, 2020", 10, 10);
        Swimming mySwimming = new Swimming("November 5th, 1995", 90, 8);

        List<Activity> activityList = new List<Activity>();
        activityList.Add(myRunning);
        activityList.Add(myBiking);
        activityList.Add(mySwimming);

        foreach(Activity myActivity in activityList)
        {
            myActivity.GetSummary();
        }
    }
}