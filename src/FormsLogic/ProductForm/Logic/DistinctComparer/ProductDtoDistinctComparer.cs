using ApplicationLayer.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.DistinctComparer
{
    public class ProductDtoDistinctComparer : IEqualityComparer<ProductDto>
    {
        public bool Equals(ProductDto x, ProductDto y)
        {
            return x.RegistrationNumber == y.RegistrationNumber;
        }

        public int GetHashCode(ProductDto obj)
        {
            return obj.RegistrationNumber.GetHashCode() ^ obj.RegistrationNumber.GetHashCode();
        }
    }
}
