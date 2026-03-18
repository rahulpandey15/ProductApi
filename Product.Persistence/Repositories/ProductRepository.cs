using Product.Domain.Entities;
using Product.Domain.Interfaces;

namespace Product.Persistence.Concrete
{
    internal class ProductRepository : IProductRepository
    {
        public Task<int> CreateProductAsync(ProductDomain order)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDomain> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
