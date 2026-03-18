using AutoMapper;
using Product.Domain.Entities;
using Product.Persistence.Entities;


namespace Product.Persistence.Mappers
{
    internal class OrderMappingExtension : Profile
    {
        public OrderMappingExtension()
        {
            CreateMap<Order, OrderDomain>().ReverseMap();
        }

    }
}
