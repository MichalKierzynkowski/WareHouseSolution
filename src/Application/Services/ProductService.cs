using ApplicationLayer.AssignValues;
using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using AutoMapper;
using Domain.Entities;
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
            var product = _mapper.Map<Product>(newProduct);
            _repository.Add(product);
            return _mapper.Map<ProductDto>(product);
        }

        public void DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }
        public void DeleteProductByRegistrationNumber(int registrationNumber)
        {
            var product = _repository.GetByRegistrationNumber(registrationNumber);
            _repository.Delete(product);
        }

        public void UpdateProduct(int registrationNumber, UpdateProductDto product)
        {
            var existingProduct = _repository.GetByRegistrationNumber(registrationNumber);
            var assignValues = new AssignProductEditDtoToProduct(existingProduct, product);
            _repository.Update(assignValues.ExistingProduct);
        }
    }
}