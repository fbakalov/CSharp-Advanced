
using FoodShortage.Models.Interfaces;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        private const int DefaultFoodIncrement = 5;

        public Rebel(string name, string group)
        {
            Name = name;
            Group = group;
        }
        public int Food {get; set;}

        public string Name { get; set; }

        public string Group { get; set; }

        public void BuyFood()
        {
            Food += DefaultFoodIncrement;
        }
    }
}
