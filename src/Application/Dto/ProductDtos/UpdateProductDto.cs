using ApplicationLayer.Dto.ProductDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class UpdateProductDto
    {
        public int RegistrationNumber { get; set; }
        public UpdateProductDetailDto EditProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }

        public UpdateProductDto(UpdateProductDetailDto editProductDetailDto)
        {
            EditProductDetailDto = editProductDetailDto;
        }
    }
}