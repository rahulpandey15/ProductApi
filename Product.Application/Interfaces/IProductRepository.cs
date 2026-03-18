using Product.Domain.Entities;

namespace Product.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductDomain> GetProductAsync(int id);

        Task<int> CreateProductAsync(ProductDomain order);
    }
}
