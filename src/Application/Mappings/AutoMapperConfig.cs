using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using ApplicationLayer.Dto.ProductDtos;

namespace ApplicationLayer.Mappings
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
                                                         {
                                                             cfg.CreateMap<Product, ProductDto>()
                                                             .ForPath(d => d.ProductDetailDto.Name, opt => opt.MapFrom(d => d.ProductDetail.Name))
                                                             .ForPath(d => d.ProductDetailDto.Type, opt => opt.MapFrom(d => d.ProductDetail.Type))
                                                             .ForPath(d => d.ProductDetailDto.ExtraDescription, opt => opt.MapFrom(d => d.ProductDetail.ExtraDescription));

                                                             cfg.CreateMap<CreateProductDto, Product>();
                                                             cfg.CreateMap<UpdateProductDto, Product>();
                                                         }
        ).CreateMapper();
    }
}