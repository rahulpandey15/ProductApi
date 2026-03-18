using AutoMapper;
using Product.Domain.Entities;
using Product.Domain.Interfaces;
using Product.Persistence.Context;
using System.Text;

namespace Product.Persistence.Concrete
{
    internal class OrderRepository : IOrderRepository
    {
        private readonly ProductDbContext _dbContext;

        public OrderRepository(ProductDbContext dbContext,
            IMapper mapper)
        {
            this._dbContext = dbContext;
        }

        public Task<int> CreateOrderAsync(OrderDomain order)
        {
            var order = 
        }

        public Task<OrderDomain> GetOrderAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
