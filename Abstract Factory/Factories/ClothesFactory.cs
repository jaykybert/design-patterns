using Patterns.Abstract_Factory.Products;

namespace Patterns.Abstract_Factory.Factories
{
    /*
     * Having factories that extend this abstract factory allows them to have specific implementations.
     * For instance, the SmartClothesFactory only returns smart clothes - you control the mixing of items (e.g. smart and casual wear).
     */
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();
    }
}
