using ApplicationLayer.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class CreateProductDetailDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? ExtraDescription { get; set; }
        public CreateProductDto CreateProductDto { get; set; }
    }
}