namespace RawData
{
    public class Cargo
    {
        private string type;
        private int weight;

        public Cargo(int weight, string type)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}