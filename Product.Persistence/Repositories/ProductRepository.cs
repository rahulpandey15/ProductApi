using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Product.Domain.Entities;
using Product.Domain.Interfaces;
using Product.Persistence.Context;
using Product.Persistence.Entities;

namespace Product.Persistence.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductRepository(ProductDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<int> CreateProductAsync(ProductDomain productDomain)
        {
            var product = _mapper.Map<Products>(productDomain);

            _dbContext.Products.Add(product);
            return await _dbContext.SaveChangesAsync();
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
