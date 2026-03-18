using AutoMapper;
using Product.Application.DTO.Request;
using Product.Domain.Entities;

namespace Product.Application.Mappers
{
    public class OrderServiceMappingExtension : Profile
    {
        public OrderServiceMappingExtension()
        {
            CreateMap<OrderDomain, CreateOrderRequest>().ReverseMap();
        }
    }
}
