
namespace FoodShortage.Models.Interfaces
{
    public interface IBuyer : INameble
    {
        int Food { get; }
        void BuyFood();
    }
}
