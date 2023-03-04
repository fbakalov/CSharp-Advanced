using System;
using System.Collections.Generic;
using BorderControl.Models;
using BorderControl.Models.Interfaces;

List<IIdentifiable> society = new();

string input;
while((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split();

	if (tokens.Length == 3)
	{
		Citizen citizen = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
		society.Add(citizen);
	}
	else
	{
		Robot robot = new(tokens[0], tokens[1]);
		society.Add(robot);
	}
}

string lastOfFake = Console.ReadLine();

List<string> fake = new();

foreach (var being in society)
{
	if (being.Id.EndsWith(lastOfFake))
	{
		fake.Add(being.Id);
	}
}

Console.WriteLine(string.Join(Environment.NewLine, fake));