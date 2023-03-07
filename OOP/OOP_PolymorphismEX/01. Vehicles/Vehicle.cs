namespace Vehicles;

public class Vehicle
{
    public Vehicle(double fuelQuantity, double consumption)
    {
        FuelQuantity = fuelQuantity;
        Consumption = consumption;
    }

    public double FuelQuantity { get; set; }

    public double Consumption { get; set;}

    public void Drive(double distance)
    {
        double fuelCopy = FuelQuantity;
        if (fuelCopy - distance * Consumption >= 0)
        {
            FuelQuantity -= distance * Consumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        
    }

    public virtual void Refuel(double liters)
    {
        FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}
