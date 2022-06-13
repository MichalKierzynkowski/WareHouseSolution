using ApplicationLayer.Dto.ProductDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class DeleteProductDto
    {
        public int RegistrationNumber { get; set; }
        public DeleteProductDetailDto DeleteProductDetailDto { get; set; }
        public DateTime AddedAt { get; set; }
        public DeleteProductDto(DeleteProductDetailDto deleteProductDetail)
        {
            DeleteProductDetailDto = deleteProductDetail;
        }
    }
}
