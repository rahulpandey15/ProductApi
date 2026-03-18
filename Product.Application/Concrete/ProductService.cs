using AutoMapper;
using Product.Application.DTO.Request;
using Product.Application.DTO.Response;
using Product.Application.Interfaces;
using Product.Domain.Entities;
using Product.Domain.Interfaces;

namespace Product.Application.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateProductAsync(
            CreateProductRequest request)
        {
            var productDomain = _mapper.Map<ProductDomain>(request);
            var response = await _productRepository.CreateProductAsync(productDomain);
            return response > 0;
        }

        public async Task<GetProductsDto> GetProductAsync(int productId)
        {
            var response = await _productRepository.GetProductAsync(productId);
            return _mapper.Map<GetProductsDto>(response);
        }

        public async Task<List<GetProductsDto>> GetProductAsync()
        {
            var response = await _productRepository.GetProductAsync();
            return _mapper.Map<List<GetProductsDto>>(response);
        }
    }
}
