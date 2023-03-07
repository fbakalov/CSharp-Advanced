namespace Vehicles;

public class StartUP
{
    static void Main()
    {
        string[] carInput = Console.ReadLine().Split();
        Car car = new(double.Parse(carInput[1]), double.Parse(carInput[2]));

        string[] truckInput = Console.ReadLine().Split();
        Truck truck = new(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

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
                else
                {
                    truck.Drive(argument);
                }
            }
            else
            {
                if (args[1] == "Car")
                {
                    car.Refuel(argument);
                }
                else
                {
                    truck.Refuel(argument);
                }
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}
