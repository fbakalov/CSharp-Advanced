using FoodShortage.Models;
using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;

List<IBuyer> buyers = new();

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] tokens = Console.ReadLine().Split();

    if (tokens.Length == 3)
    {
        Rebel rebel = new(tokens[0], tokens[1]);
        buyers.Add(rebel);
    }
    else
    {
        IBuyer citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
        buyers.Add(citizen);
    }
}
string nameToBuyFood;
while ((nameToBuyFood = Console.ReadLine()) != "End")
{
    buyers.FirstOrDefault(buyer => buyer.Name == nameToBuyFood)?.BuyFood();
}

Console.WriteLine(buyers.Sum(b => b.Food));