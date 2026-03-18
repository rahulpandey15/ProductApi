using Product.Domain.Entities;

namespace Product.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task<OrderDomain> GetOrderAsync(int id);

        Task<int> CreateOrderAsync(OrderDomain order);
    }
}
