using Product.Application.DTO.Request;
using Product.Application.DTO.Response;

namespace Product.Application.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProductAsync(CreateProductRequest request);

        Task<GetProductsDto> GetProductAsync(int productId);

        Task<List<GetProductsDto>> GetProductAsync();

    }
}
