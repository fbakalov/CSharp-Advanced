namespace VehiclesExtention;

public class Bus : Vehicle
{
    private double consumptionWithoutPassangers;
    public Bus(double fuelQuantity, double consumption, double tankCapacity) : base(fuelQuantity, consumption, tankCapacity)
    {
        consumptionWithoutPassangers = consumption;
        Consumption += 1.4;
    }

    public void DriveWithout(double distance)
    {
        double fuelCopy = FuelQuantity;
        if (fuelCopy - distance * consumptionWithoutPassangers >= 0)
        {
            FuelQuantity -= distance * consumptionWithoutPassangers;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
    }
}
