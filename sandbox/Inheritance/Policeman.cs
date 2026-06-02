using System;

class Policeman: Person
{
    private string _weapons;

    public Policeman(string weapons, string firstName,
    string lastName, int age, int weight) : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        return $"Weapons: {_weapons}, {GetPersonInformation()}";
    }
}