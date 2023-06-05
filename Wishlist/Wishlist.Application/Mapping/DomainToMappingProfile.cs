using AutoMapper;
using Wishlist.Application.DTOs.Product;
using Wishlist.Domain.Entities;

namespace Wishlist.Application.Mapping
{
    public class DomainToMappingProfile : Profile
    {
        public DomainToMappingProfile()
        {
            CreateMap<Product, ProductOutput>().ReverseMap();
        }
    }
}
