using ApplicationLayer.Dto.ProductDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class CreateProductDto
    {
        public int RegistrationNumber { get; set; }
        public CreateProductDetailDto CreateProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }

        public CreateProductDto(CreateProductDetailDto createProductDetailDto)
        {
            CreateProductDetailDto = createProductDetailDto;
        }
    }
}