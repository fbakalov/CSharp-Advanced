namespace VehiclesExtention;

public class StartUP
{
    static void Main()
    {
        string[] carInput = Console.ReadLine().Split();
        Car car = new(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));

        string[] truckInput = Console.ReadLine().Split();
        Truck truck = new(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));

        string[] busInput = Console.ReadLine().Split();
        Bus bus = new(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split();

            double argument = double.Parse(args[2]);

            if (args[0] == "Drive")
            {
                if (args[1] == "Car")
                {
                    car.Drive(argument);
                }
                else if (args[1] == "Truck")
                {
                    truck.Drive(argument);
                }
                else
                {
                    bus.Drive(argument);
                }
            }
            else if (args[0] == "DriveEmpty")
            {
                bus.DriveWithout(argument);
            }
            else
            {
                if (args[1] == "Car")
                {
                    car.Refuel(argument);
                }
                else if (args[1] == "Truck")
                {
                    truck.Refuel(argument);
                }
                else
                {
                    bus.Refuel(argument);
                }
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}
