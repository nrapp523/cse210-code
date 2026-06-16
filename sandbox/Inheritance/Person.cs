using System.Runtime.CompilerServices;
using System;

class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int weight, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }
    public void SetAge(int age)
    {
        _age = age;
        if (age < 0 || age > 125)
        {
            _age = 0;
            Console.WriteLine("Incorrect AGe");
        }
    }
    public void SetWeight(int age)
    {
        _weight = weight;
        if (weight < 0 || weight > 500)
        {
            _we ight= 0;
            Console.WriteLine("Incorrect weight");
        }
    }
    
    
}