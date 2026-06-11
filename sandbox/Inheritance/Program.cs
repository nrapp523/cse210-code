// See https://aka.ms/new-console-template for more information
using System;



Person myPerson = new Person("bob", "robert", 57, 198);
Console.WriteLine(myPerson.GetPersonInformation());

Policeman myPolice = new Policeman("pistol", "bob", "robert", 57, 198);

Console.WriteLine(myPolice.GetPoliceInformation());

Doctor myDoctor = new Doctor("MD", "Dan", "Ramirez", 25, 150);
Console.WriteLine(myDoctor.GetDoctorInformation());
