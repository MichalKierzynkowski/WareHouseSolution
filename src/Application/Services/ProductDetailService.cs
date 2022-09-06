using ApplicationLayer.Dto.ProductDetailDtos;
using ApplicationLayer.Interfaces;
using AutoMapper;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IProductDetailRepository _productDetailRepository;

        public ProductDetailService(IMapper mapper, IProductDetailRepository productDetailRepository, IProductRepository productRepository)
        {
            _productDetailRepository = productDetailRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductDetailDto> GetAllProductDetails()
        {
            throw new NotImplementedException();
        }

        public ProductDetailDto GetProductById(int id)
        {
            throw new NotImplementedException();
        }
    }
}