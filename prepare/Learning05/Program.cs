using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("red",20);   
        Rectangle myRectangle = new Rectangle(20, 30, "Red");
        Circle myCircle = new Circle(20, "Red");
        List<Shape> myList = new List<Shape>();
        myList.Add(mySquare);
        myList.Add(myRectangle);
        myList.Add(myCircle);
        foreach(Shape myShape in myList)
        {
            Console.WriteLine($"Color: {myShape.GetColor()} Area: {myShape.GetArea()}");
        }
    }
}