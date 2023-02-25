using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = GetEngines(n);

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = GetCars(m, engines);

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString()); 
            }
        }

        private static List<Car> GetCars(int m, List<Engine> engines)
        {
            List<Car> cars = new();
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string modelEngine = input[1];
                Engine engine = engines.Find(x => x.Model == modelEngine);

                Car newCar;
                if (input.Length == 2)
                {
                    newCar = new Car(model, engine);
                }
                else if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        int weight = int.Parse(input[2]);
                        newCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = input[2];
                        newCar = new Car(model, engine, color);
                    }
                }
                else
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    newCar = new Car(model, engine, weight, color);
                }

                cars.Add(newCar);

            }
            return cars;
        }

        private static List<Engine> GetEngines(int n)
        {
            List<Engine> engines = new();
            for (int i = 0; i < n; i++)
            {
                string[] inputEngine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputEngine[0];
                int power = int.Parse(inputEngine[1]);

                Engine newEngine;
                if (inputEngine.Length == 2)
                {
                    newEngine = new Engine(model, power);
                }
                else if (inputEngine.Length == 3)
                {
                    if (Char.IsDigit(inputEngine[2][0]))
                    {
                        int displacement = int.Parse(inputEngine[2]);
                        newEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = inputEngine[2];
                        newEngine = new Engine(model, power, efficiency);
                    }
                }
                else
                {
                    int displacement = int.Parse(inputEngine[2]);
                    string efficiency = inputEngine[3];
                    newEngine = new Engine(model, power, displacement, efficiency);
                }

                engines.Add(newEngine);
            }
            return engines;
        }
    }
}