namespace Vehicles;

public class Truck : Vehicle
{
    private const double fuelConsumptionIncreese = 1.6;

    public Truck(double fuelQuantity, double consumption) : base(fuelQuantity, consumption)
    {
        Consumption = consumption + fuelConsumptionIncreese;
    }

    public override void Refuel(double liters)
    {
        FuelQuantity += liters * 0.95;
    }
}