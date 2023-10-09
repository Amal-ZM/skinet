using API.Dtos;
using API.Helpers;
using AutoMapper;
using Core.Entities;

namespace API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product,ProductToReturnDto>()
            .ForMember(d=>d.ProductBrand,o=>o.MapFrom(d=>d.ProductBrand.Name))
             .ForMember(d=>d.ProductType,o=>o.MapFrom(d=>d.ProductType.Name))
             .ForMember(d=>d.PictureUrl,o=>o.MapFrom<ProductUrlResolver>());
        }
    }
}