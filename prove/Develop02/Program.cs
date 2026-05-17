using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal.MenuString();
        myJournal.MenuInput();
        /*
         * My added creativity was whenever the journal
         * is displayed if it was taken from a specific
         * it will say the full path of the location if
         * not then it will just say it is not saved yet.
         */
    }
}