namespace VehiclesExtention;

public class Car : Vehicle
{
    private const double fuelConsumptionIncreese = 0.9;

    public Car(double fuelQuantity, double consumption, double tankCapacity) : base(fuelQuantity, consumption, tankCapacity)
    {
        Consumption = consumption + fuelConsumptionIncreese; 
    }

}
