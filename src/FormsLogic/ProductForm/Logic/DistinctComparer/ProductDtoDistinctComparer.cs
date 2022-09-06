using ApplicationLayer.Dto.ProductDtos;

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
