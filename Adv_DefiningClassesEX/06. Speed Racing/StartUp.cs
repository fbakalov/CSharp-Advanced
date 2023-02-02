using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Car newCar = new() 
                { 
                    Model = input[0],
                    FuelAmount = double.Parse(input[1]), 
                    FuelConsumptionPerKilometer = double.Parse(input[2]) 
                };
                cars.Add(newCar.Model, newCar);
            }

            string inputDrive;
            while ((inputDrive = Console.ReadLine()) != "End")
            {
                string[] tokens = inputDrive.Split();
                string model = tokens[1];
                double distance = double.Parse(tokens[2]);

                cars[model].Drive(distance);
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
