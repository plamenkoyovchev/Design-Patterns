using Strategy.Models;

namespace Strategy.Strategies.Shipping
{
    public interface IShippingProvider
    {
        void Ship(Order order);
    }
}