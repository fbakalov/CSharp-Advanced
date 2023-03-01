﻿namespace _02._Cars;

public class Tesla : IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        Battery = battery;
        Model = model;
        Color = color;
    }

    public int Battery {get; set;}

    public string Model { get; set;} 

    public string Color { get; set; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";
    }
}