using ApplicationLayer.Interfaces;
using ApplicationLayer.Mappings;
using ApplicationLayer.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using NSubstitute;
using System;
using Xunit;

namespace FunctionalityTests.ProductServiceTests
{
    public class ReturnProductsFromDB
    {
        private readonly IProductService _productService;
        private readonly IProductRepository _productRepository = Substitute.For<IProductRepository>();
        private readonly IMapper _mapper;

        public ReturnProductsFromDB()
        {
            _mapper = AutoMapperConfig.Initialize();
            _productService = new ProductService(_productRepository, _mapper);
        }

        [Fact]
        public void GetProductById_ShouldReturnProduct_WhenProductExists()
        {
            var currentDate = DateTime.Now;
            var product = new Product
            {
                Id = 1,
                AddedAt = currentDate,
                RegistrationNumber = 1,
                ProductDetail = new ProductDetail
                {
                    Name = "test",
                    ExtraDescription = "test",
                    Type = "Test"
                }
            };

            _productRepository.GetById(product.Id).
                Returns(product);
            var customer = _productRepository.
                GetById(product.Id);

            Assert.Equal(product.Id, customer.Id);
        }

        [Fact]
        public void GetProductByRegistrationNumber_ShouldReturnProduct_WhenProductExists()
        {
            var currentDate = DateTime.Now;
            var product = new Product
            {
                Id = 1,
                AddedAt = currentDate,
                RegistrationNumber = 5,
                ProductDetail = new ProductDetail
                {
                    Name = "test",
                    ExtraDescription = "test",
                    Type = "Test"
                }
            };
            _productRepository.GetByRegistrationNumber
                (product.RegistrationNumber).Returns(product);
            var productFromDb = _productRepository.
                GetByRegistrationNumber(product.RegistrationNumber);

            Assert.Equal(product.RegistrationNumber, productFromDb.RegistrationNumber);
        }
    }
}