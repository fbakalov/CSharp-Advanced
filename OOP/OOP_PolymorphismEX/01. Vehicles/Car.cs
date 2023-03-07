namespace Vehicles;

public class Car : Vehicle
{
    private const double fuelConsumptionIncreese = 0.9;

    public Car(double fuelQuantity, double consumption) : base(fuelQuantity, consumption)
    {
        Consumption = consumption + fuelConsumptionIncreese; 
    }

}
