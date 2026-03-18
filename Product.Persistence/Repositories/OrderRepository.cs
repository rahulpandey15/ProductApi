using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Product.Domain.Entities;
using Product.Domain.Interfaces;
using Product.Persistence.Context;
using System.Text;

namespace Product.Persistence.Repositories
{
    internal class OrderRepository : IOrderRepository
    {
        private readonly ProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrderRepository(ProductDbContext dbContext,
            IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public Task<int> CreateOrderAsync(OrderDomain order)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDomain> GetOrderAsync(int id)
        {
            return await _dbContext.Orders
                 .Where(x => x.Id == id)
                 .ProjectTo<OrderDomain>(_mapper.ConfigurationProvider)
                 .FirstOrDefaultAsync();
                
        }
    }
}
