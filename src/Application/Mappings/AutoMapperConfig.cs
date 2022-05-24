using ApplicationLayer.Dto.ProductDtos;
using AutoMapper;
using Domain.Entities;

namespace ApplicationLayer.Mappings
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
                            {
                                cfg.CreateMap<Product, ProductDto>()
                                .ForPath(d => d.ProductDetailDto.Name, opt => opt.MapFrom(d => d.ProductDetail.Name))
                                .ForPath(d => d.ProductDetailDto.Type, opt => opt.MapFrom(d => d.ProductDetail.Type))
                                .ForPath(d => d.ProductDetailDto.ExtraDescription, opt => opt.MapFrom(d => d.ProductDetail.ExtraDescription))
                                .ForPath(d => d.ProductDetailDto.ExtraDescription, act => act.MapFrom(
                                src => (src.ProductDetail.ExtraDescription != null ? src.ProductDetail.ExtraDescription : "------")
                                ));
                                cfg.CreateMap<CreateProductDto, Product>();
                                cfg.CreateMap<UpdateProductDto, Product>();
                            }
                ).CreateMapper();
    }
}