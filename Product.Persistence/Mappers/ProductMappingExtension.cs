using AutoMapper;
using Product.Domain;
using Product.Persistence.Entities;


namespace Product.Persistence.Mappers
{
    public class ProductMappingExtension : Profile
    {
        public ProductMappingExtension()
        {
            CreateMap<Products, ProductDomain>().ReverseMap();
        }
    }
}
