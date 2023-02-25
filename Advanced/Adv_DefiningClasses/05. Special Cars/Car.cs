namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new();
            string tireInput;
            while ((tireInput = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = tireInput.Split();
                tires.Add(new Tire[4]
                {
                    new Tire(int.Parse(tokens[0]), double.Parse(tokens[1])),
                    new Tire(int.Parse(tokens[2]), double.Parse(tokens[3])),
                    new Tire(int.Parse(tokens[4]), double.Parse(tokens[5])),
                    new Tire(int.Parse(tokens[6]), double.Parse(tokens[7])),
                });
            }

            List<Engine> engines = new();
            string engineInput;
            while ((engineInput = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = engineInput.Split();
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> cars = new();
            string carInput;
            while ((carInput = Console.ReadLine()) != "Show special")
            {
                string[] tokens = carInput.Split();

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
            }

            List<Car> specialCars = new();
            foreach (var car in cars)
            {
                int year = car.Year;
                int horsePower = car.Engine.HorsePower;
                double sumOfPressure = 0;
                foreach (var tire in car.Tires)
                {
                    sumOfPressure += tire.Pressure;
                }

                if (year >= 2017 && horsePower > 330 && sumOfPressure >= 9 && sumOfPressure <= 10)
                {
                    car.Drive(0.2);
                    specialCars.Add(car);
                }
            }

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
    public class Car
    {

        string field;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) 
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            fuelQuantity = this.FuelQuantity;
            fuelConsumption = this.FuelConsumption;

            if (fuelQuantity - fuelConsumption * distance > 0)
            {
                this.fuelQuantity -= fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nHorsePowers: {this.Engine.HorsePower}\nFuel: {this.FuelQuantity:F2}";
        }

        
    }
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
