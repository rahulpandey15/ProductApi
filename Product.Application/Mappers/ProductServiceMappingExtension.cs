using AutoMapper;
using Product.Application.DTO.Request;
using Product.Application.DTO.Response;
using Product.Domain.Entities;


namespace Product.Application.Mappers
{
    public class ProductServiceMappingExtension: Profile
    {
        public ProductServiceMappingExtension()
        {
            CreateMap<ProductDomain, CreateProductRequest>().ReverseMap();
            CreateMap<ProductDomain, GetProductsDto>().ReverseMap();

        }
    }
}
