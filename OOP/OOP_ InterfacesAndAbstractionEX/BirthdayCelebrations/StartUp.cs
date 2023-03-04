using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Sockets;

List<IBirthable> birthables = new();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();
    string kind = tokens[0];

    if (kind == "Citizen")
    {
        Citizen citizen = new(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
        birthables.Add(citizen);
    }
    else if (kind == "Pet")
    {
        Pet pet = new(tokens[1], tokens[2]);
        birthables.Add(pet);
    }
}

string year = Console.ReadLine();

foreach (var element in birthables)
{
    if (element.BirthDate.EndsWith(year))
    {
        Console.WriteLine(element.BirthDate);
    }
}

