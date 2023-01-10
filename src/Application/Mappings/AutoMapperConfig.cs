using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.Sale;
using ApplicationLayer.Dto.WareHouse;
using AutoMapper;
using Domain.Entities;

namespace ApplicationLayer.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>()
                    .ForPath(d => d.ProductDetailDto.Name, opt => opt.MapFrom(d => d.ProductDetail.Name))
                    .ForPath(d => d.ProductDetailDto.Type, opt => opt.MapFrom(d => d.ProductDetail.Type))
                    .ForPath(d => d.ProductDetailDto.ExtraDescription,
                        opt => opt.MapFrom(d => d.ProductDetail.ExtraDescription))
                    .ForPath(d => d.ProductDetailDto.ExtraDescription, act => act.MapFrom(
                        src => (src.ProductDetail.ExtraDescription != null
                            ? src.ProductDetail.ExtraDescription
                            : "------")
                    ));

                cfg.CreateMap<UpdateProductDto, Product>()
                    .ForPath(d => d.ProductDetail.Name, opt => opt.MapFrom(d => d.EditProductDetailDto.Name));
                cfg.CreateMap<UpdateProductDto, Product>();
                cfg.CreateMap<CreateProductDto, Product>()
                    .ForPath(d => d.ProductDetail.Name, opt => opt.MapFrom(d => d.CreateProductDetailDto.Name))
                    .ForPath(d => d.ProductDetail.Type, opt => opt.MapFrom(d => d.CreateProductDetailDto.Type))
                    .ForPath(d => d.ProductDetail.ExtraDescription,
                        opt => opt.MapFrom(d => d.CreateProductDetailDto.ExtraDescription));

                cfg.CreateMap<WareHouse, WareHouseDto>()
                    .ForPath(d => d.Unit, opt => opt.MapFrom(d => d.Unit))
                    .ForPath(d => d.SellPrice, opt => opt.MapFrom(d => d.SellPrice))
                    .ForPath(d => d.PurchasePrice, opt => opt.MapFrom(d => d.PurchasePrice))
                    .ForPath(d => d.Date, opt => opt.MapFrom(d => d.Date))
                    .ForPath(d => d.Quantity, opt => opt.MapFrom(d => d.Quantity))
                    .ForPath(d => d.Products, opt => opt.MapFrom(d => d.Products))
                    .ForPath(d => d.IsReturned, opt => opt.MapFrom(src => (src.IsReturned ? "Tak" : "Nie")));

                cfg.CreateMap<CreateWareHouseDto, WareHouse>()
                    .ForPath(d => d.Date, opt => opt.MapFrom(d => d.Date))
                    .ForPath(d => d.Products, opt => opt.MapFrom(d => d.Products))
                    .ForPath(d => d.PurchasePrice, opt => opt.MapFrom(d => d.PurchasePrice))
                    .ForPath(d => d.Quantity, opt => opt.MapFrom(d => d.Quantity))
                    .ForPath(d => d.SellPrice, opt => opt.MapFrom(d => d.SellPrice))
                    .ForPath(d => d.Unit, opt => opt.MapFrom(d => d.Unit))
                    .ForPath(d => d.IsReturned, opt => opt.MapFrom(d=>ReturnedResolver.Resolve(d.IsReturned)));

                cfg.CreateMap<Return, ReturnDto>()
                    .ForPath(d => d.Unit, opt => opt.MapFrom(d => d.Unit))
                    .ForPath(d => d.SellPrice, opt => opt.MapFrom(d => d.SellPrice))
                    .ForPath(d => d.PurchasePrice, opt => opt.MapFrom(d => d.PurchasePrice))
                    .ForPath(d => d.Date, opt => opt.MapFrom(d => d.Date))
                    .ForPath(d => d.Quantity, opt => opt.MapFrom(d => d.Quantity))
                    .ForPath(d => d.Products, opt => opt.MapFrom(d => d.Products))
                    .ForPath(d => d.IsReturned, opt => opt.MapFrom(src => (src.IsReturned ? "Tak" : "Nie")));


                cfg.CreateMap<CreateReturnDto, Return>()
                    .ForPath(d => d.Date, opt => opt.MapFrom(d => d.Date))
                    .ForPath(d => d.Products, opt => opt.MapFrom(d => d.Products))
                    .ForPath(d => d.PurchasePrice, opt => opt.MapFrom(d => d.PurchasePrice))
                    .ForPath(d => d.Quantity, opt => opt.MapFrom(d => d.Quantity))
                    .ForPath(d => d.SellPrice, opt => opt.MapFrom(d => d.SellPrice))
                    .ForPath(d => d.Unit, opt => opt.MapFrom(d => d.Unit))
                    .ForPath(d => d.IsReturned, opt => opt.MapFrom(opt => opt.IsReturned));


                cfg.CreateMap<CreateSaleDto, Sale>()
                    .ForPath(d => d.EndPrice, opt => opt.MapFrom(d => d.EndPrice))
                    .ForPath(d => d.Margin, opt => opt.MapFrom(d => d.Margin))
                    .ForPath(d => d.Discount, opt => opt.MapFrom(d => d.Discount))
                    .ForPath(d => d.Profit, opt => opt.MapFrom(d => d.Profit))
                    .ForPath(d => d.Returns, opt => opt.MapFrom(d => d.Returns))
                    .ForPath(d => d.PaymentMethod, opt => opt.MapFrom(d => d.PaymentMethod))
                    .ForPath(d => d.WareHouses, opt => opt.MapFrom(d => d.WareHouses))
                    .ForPath(d => d.Id, opt => opt.Ignore())
                    .ForPath(d => d.Date, opt => opt.MapFrom(d => d.Date));

                cfg.CreateMap<Sale, SaleDto>()
                    .ForPath(d => d.EndPrice, opt => opt.MapFrom(d => d.EndPrice))
                    .ForPath(d => d.Margin, opt => opt.MapFrom(d => d.Margin))
                    .ForPath(d => d.Discount, opt => opt.MapFrom(d => d.Discount))
                    .ForPath(d => d.Profit, opt => opt.MapFrom(d => d.Profit))
                    .ForPath(d => d.Returns, opt => opt.MapFrom(d => d.Returns))
                    .ForPath(d => d.PaymentMethod, opt => opt.MapFrom(d => d.PaymentMethod))
                    .ForPath(d => d.WareHouses, opt => opt.MapFrom(d => d.WareHouses))
                    .ForPath(d => d.Id, opt => opt.MapFrom(d => d.Id))
                    .ForPath(d => d.Date, opt => opt.MapFrom(d => d.Date));


            }
        ).CreateMapper();
    }

    public static class ReturnedResolver
    {
        public static bool Resolve(string value)
        {
            if (value == "Tak")
            {
                return true;
            }

            return false;
        }
    }
}

