namespace CarManager.Tests
{
    using NUnit.Framework;
    using System.Reflection;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void SetUp()
        {
            car = new("Pegueot", "206", 5.4, 50);
        }
        [TearDown]
        public void TearDown()
        {
            car = null;
        }

        [Test]
        public void Test_CreateCar()
        {
            car = new("Pegueot", "206", 5.4, 50);
            Assert.That(car.Make, Is.EqualTo("Pegueot"));
            Assert.That(car.Model, Is.EqualTo("206"));
            Assert.That(car.FuelConsumption, Is.EqualTo(5.4));
            Assert.That(car.FuelCapacity, Is.EqualTo(50));
            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_CreateCarFailsMakeIsNullOrEmpty(string make)
        {
            ArgumentException exeption = Assert
                .Throws<ArgumentException>(() => new Car(make, "206", 5.4, 50));
            Assert.That(exeption.Message, Is.EqualTo("Make cannot be null or empty!"));
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void Test_CreateCarFailsModelIsNullOrEmpty(string model)
        {
            ArgumentException exeption = Assert
                .Throws<ArgumentException>(() => new Car("Pegueot", model, 5.4, 50));
            Assert.That(exeption.Message, Is.EqualTo("Model cannot be null or empty!"));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_CreateCarFailsFuelConsumptionIsZeroOrNegative(double fuelConsumption)
        {
            ArgumentException exeption = Assert
                .Throws<ArgumentException>(() => new Car("Pegueot", "206", fuelConsumption, 50));
            Assert.That(exeption.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_CreateCarFailsFuelCapacityIsZeroOrNegative(double fuelCapacity)
        {
            ArgumentException exeption = Assert
                .Throws<ArgumentException>(() => new Car("Pegueot", "206", 5.4, fuelCapacity));
            Assert.That(exeption.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void Test_RefuelThrowsIfZeroOrNegative(double amount)
        {
            ArgumentException exeption = Assert
                .Throws<ArgumentException>(() => car.Refuel(amount));
            Assert.That(exeption.Message, Is.EqualTo("Fuel amount cannot be zero or negative!"));
        }
        [Test]
        public void Test_RefuelShouldFuelAmountIsEqualToCapacity()
        {
            car.Refuel(50);

            Assert.That(car.FuelAmount, Is.EqualTo(50));
        }
        [Test]
        public void Test_RefuelShouldfuelAmountIsMoreThencapacity()
        {
            car.Refuel(55);

            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }
        [Test]
        public void Test_DriveIfFuelNotEnough()
        {
            InvalidOperationException exeption = Assert
                .Throws<InvalidOperationException>(() => car.Drive(1));
            Assert.That(exeption.Message, Is.EqualTo("You don't have enough fuel to drive!"));
        }
        [Test]
        public void Test_Drive()
        {
            car.Refuel(10);
            car.Drive(100);

            Assert.That(car.FuelAmount, Is.EqualTo(4.6));
        }
    }
}