using ApplicationLayer.Dto.ProductDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class EditProductDto
    {
        public int RegistrationNumber { get; set; }
        public EditProductDetailDto EditProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }

        public EditProductDto(EditProductDetailDto editProductDetailDto)
        {
            EditProductDetailDto = editProductDetailDto;
        }
    }
}