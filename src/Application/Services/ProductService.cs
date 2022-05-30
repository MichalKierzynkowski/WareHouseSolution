using ApplicationLayer.AssignValues;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class ProductService : IProductService

    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = productRepository;
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _repository.GetAll().ToList();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public ProductDto GetProductByRegistrationNumber(int registrationNumber)
        {
            var product = _repository.GetByRegistrationNumber(registrationNumber);
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductDto AddNewProduct(CreateProductDto newProduct)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int registrationNumber, UpdateProductDto product)
        {
            var existingProduct = _repository.GetByRegistrationNumber(registrationNumber);
            var assignValues = new AssignProductEditDtoToProduct(existingProduct, product);
            _repository.Update(assignValues.ExistingProduct);
        }
    }
}