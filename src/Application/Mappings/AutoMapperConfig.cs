using Application.Dto.Product;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApplication.NewForms;

namespace Application.Mappings
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
                 {
                     cfg.CreateMap<Product, ProductDto>();
                     cfg.CreateMap<CreateProductDto, Product>();
                     cfg.CreateMap<UpdateProductDto, Product>();
                 }
        ).CreateMapper();
    }
}