using ApplicationLayer.Dto.ProductDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Interfaces
{
    public interface IProductDetailService
    {
        IEnumerable<ProductDetailDto> GetAllProductDetails();

        ProductDetailDto GetProductById(int id);
    }
}