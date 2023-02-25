using System;

namespace SpeedRacing
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumptionPerKilometer;
        double travelledDistance;

        public Car()
        {
            this.travelledDistance = 0;
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double consumed = amountOfKm * this.FuelConsumptionPerKilometer;
            if (consumed > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.TravelledDistance += amountOfKm;
                this.FuelAmount -= consumed;
            }
        }
    }
}
