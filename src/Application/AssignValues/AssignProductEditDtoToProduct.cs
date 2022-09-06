using ApplicationLayer.Dto.ProductDtos;
using Domain.Entities;

namespace ApplicationLayer.AssignValues
{
    public class AssignProductEditDtoToProduct
    {
        public Product ExistingProduct { get; }
        public UpdateProductDto UpdateProduct { get; }

        public AssignProductEditDtoToProduct(Product existingProduct, UpdateProductDto product)
        {
            ExistingProduct = existingProduct;
            UpdateProduct = product;
            AssignValues();
        }

        public void AssignValues()
        {
            ExistingProduct.ProductDetail.Name = UpdateProduct.EditProductDetailDto.Name;
            ExistingProduct.ProductDetail.Type = UpdateProduct.EditProductDetailDto.Type;
            ExistingProduct.ProductDetail.LastChangedAt = UpdateProduct.EditProductDetailDto.LastChangedAt;
            ExistingProduct.ProductDetail.ExtraDescription = UpdateProduct.EditProductDetailDto.ExtraDescription;
        }
    }
}