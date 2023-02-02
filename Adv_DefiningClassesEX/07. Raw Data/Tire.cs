namespace RawData
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        public double Pressure { get => pressure; set => pressure = value; }
        public int Age { get => age; set => age = value; }
    }
}