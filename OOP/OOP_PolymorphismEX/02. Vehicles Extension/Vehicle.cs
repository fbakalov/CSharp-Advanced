namespace VehiclesExtention;

public class Vehicle
{
    public Vehicle(double fuelQuantity, double consumption, double tankCapacity)
    {
        FuelQuantity = fuelQuantity;
        Consumption = consumption;
        TankCapacity = tankCapacity;

        if (FuelQuantity > TankCapacity)
        {
            FuelQuantity = 0;
        }
    }

    public double FuelQuantity { get; set; }

    public double Consumption { get; set;}

    public double TankCapacity { get; private set; }    

    public virtual void Drive(double distance)
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
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }

        double fuelCopy = FuelQuantity;

        if (fuelCopy + liters < TankCapacity)
        {
            FuelQuantity += liters;
        }
        else
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}
