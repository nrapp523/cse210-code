// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Internal;



Person myPerson = new Person("bob", "robert", 57, 198);
Console.WriteLine(myPerson.GetPersonInformation());

Policeman myPolice = new Policeman("pistol", "bob", "robert", 57, 198);

Console.WriteLine(myPolice.GetPoliceInformation());

Doctor myDoctor = new Doctor("MD", "Dan", "Ramirez", 25, 150);
Console.WriteLine(myDoctor.GetDoctorInformation());

List<Person> myPeople = new List<Person>();
myPeople.Add(myPerson);
myPeople.Add(myDoctor);
myPeople.Add(myPolice);

foreach(Person person in myPeople)
{
    Console.WriteLine(person.GetPersonInformation());
}
