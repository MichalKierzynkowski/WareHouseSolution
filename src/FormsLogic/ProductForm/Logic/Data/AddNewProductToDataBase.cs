using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Data
{
    public class AddNewProductToDataBase
    {
        public CreateProductDto CreateProductDto { get; set; }
        public IProductService ProductService { get; set; }

        public AddNewProductToDataBase(CreateProductDto createProductDto, IProductService productService)
        {
            CreateProductDto = createProductDto;
            ProductService = productService;
            AddNewProduct();
        }

        public void AddNewProduct()
        {
            ProductService.AddNewProduct(CreateProductDto);
        }
    }
}