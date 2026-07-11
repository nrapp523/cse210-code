using System;

class Program
{
    static void Main(string[] args)
    {
        Video myVideo1 = new Video("for real", "jared", 250);
        Video myVideo2 = new Video("Caught IRL", "Seth", 600);
        Video myVideo3 = new Video("Why is birds", "Johnny", 700);

        myVideo1.addComment("Able", "I'm tired");
        myVideo1.addComment("Braden", "Wooow");
        myVideo1.addComment("Corey", "Huulllo");

        myVideo2.addComment("Derrick", "oop");
        myVideo2.addComment("Ethan", "abstraction");
        myVideo2.addComment("Frank", "encapsulation");

        myVideo3.addComment("Garret", "inheritance");
        myVideo3.addComment("Hayden", "Polymorphism");
        myVideo3.addComment("Ian", "test");

        List<Video> videoList = new List<Video>();
        videoList.Add(myVideo1);
        videoList.Add(myVideo2);
        videoList.Add(myVideo3);

        foreach(Video myVideo in videoList)
        {
            myVideo.ListInfo();
        }

        
    }
}