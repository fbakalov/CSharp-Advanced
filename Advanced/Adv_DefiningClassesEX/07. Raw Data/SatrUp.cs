using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                Car car = new Car(
                    input[0],
                    int.Parse(input[1]),
                    int.Parse(input[2]),
                    int.Parse(input[3]),
                    input[4],
                    double.Parse(input[5]),
                    int.Parse(input[6]),
                    double.Parse(input[7]),
                    int.Parse(input[8]),
                    double.Parse(input[9]),
                    int.Parse(input[10]),
                    double.Parse(input[11]),
                    int.Parse(input[12]));

                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<string> filteredCars = new();
            if (command == "fragile")
            {
                filteredCars = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                .Select(c => c.Model)
                .ToList();
            }
            else if (command == "flammable")
            {
                filteredCars = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, filteredCars));
        }
    }
}