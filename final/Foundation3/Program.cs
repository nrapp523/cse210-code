using System;

class Program
{
    static void Main(string[] args)
    {
        Address myLectureAddress = new Address("585 N 400 E");
        Address myReceptionAddress = new Address("400 N 200 W");
        Address myOutdoorAddress = new Address("200 S 300 E");
        Lecture myLecture = new Lecture("Journal of Discources", "historical lecture on journal of discourses", "July 5th", "5 PM", myLectureAddress, 500, "Joey Rapp");
        Reception myReception = new Reception("Wedding", "Marriage of Tate to Mcrae", "August 12th", "9 Am", myReceptionAddress, "jkr@gmail.com");
        Outdoor myOutdoor = new Outdoor("Party", "party in the park", "June 28th", "7 PM", myOutdoorAddress, "Sunny");
        myLecture.GenerateStandardDetails();
        myLecture.GenerateFullDetails();
        myLecture.GenerateShortDetails();
        myReception.GenerateStandardDetails();
        myReception.GenerateFullDetails();
        myReception.GenerateShortDetails();
        myOutdoor.GenerateStandardDetails();
        myOutdoor.GenerateShortDetails();
        myOutdoor.GenerateShortDetails();
    }
     
}