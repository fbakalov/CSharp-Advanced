using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffePrice = 3.50M;

        public Coffee(string name, double caffeine)
            : base(name, CoffePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine { get; private set; }
    }
}
