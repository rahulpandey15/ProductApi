using Product.Domain.Entities;

namespace Product.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductDomain> GetProductAsync(int id);
        Task<List<ProductDomain>> GetProductAsync();
        Task<int> CreateProductAsync(ProductDomain productDomain);
    }
}
