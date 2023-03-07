namespace VehiclesExtention;

public class Truck : Vehicle
{
    private const double fuelConsumptionIncreese = 1.6;

    public Truck(double fuelQuantity, double consumption, double tankCapacity) : base(fuelQuantity, consumption, tankCapacity)
    {
        Consumption = consumption + fuelConsumptionIncreese;
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }
        double fuelCopy = FuelQuantity;

        if (fuelCopy + liters < TankCapacity)
        {
            FuelQuantity += liters * 0.95;
        }
        else
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }
    }
}