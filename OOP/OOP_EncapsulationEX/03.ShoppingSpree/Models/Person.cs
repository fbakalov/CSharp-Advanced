
namespace _03.ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;

        private List<Product> bagProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagProducts = new List<Product>();
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            } 
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public List<Product> BagProducts { get => bagProducts; set => bagProducts = value; }

        public string Add(Product product)
        {
            if (Money < product.Cost)
            {
                return $"{Name} can't afford {product}";
            }

            bagProducts.Add(product);

            Money -= product.Cost;

            return $"{Name} bought {product}";
        }

        public override string ToString()
        {
            string productsString = bagProducts.Any()
                 ? string.Join(", ", bagProducts)
                 : "Nothing bought";

            return $"{Name} - {productsString}";
        }
    }
}
