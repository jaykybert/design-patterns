using Patterns.Abstract_Factory.Factories;
using Patterns.Abstract_Factory.Products;

namespace Patterns.Abstract_Factory
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

        public string DescribeOutfit()
        {
            return $"Today I'm wearing a {_shirt.GetType().Name} and a pair of {_trousers.GetType().Name}";
        }
    }
}
