using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Product.Application.Interfaces;
using Product.Domain.Entities;
using Product.Persistence.Context;

namespace Product.Persistence.Concrete
{
    internal class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductRepository(ProductDbContext dbContext,
            IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }
        public Task<int> CreateProductAsync(ProductDomain order)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDomain> GetProductAsync(int id)
        {
            return await _dbContext.Products
                .Where(x => x.Id == id)
                .ProjectTo<ProductDomain>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
    }
}
