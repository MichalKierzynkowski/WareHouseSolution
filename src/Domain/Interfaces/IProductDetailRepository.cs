using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductDetailRepository
    {
        IEnumerable<ProductDetail> GetAll();

        ProductDetail GetById(int id);

        Product Add(ProductDetail productDetail);

        void Update(ProductDetail productDetail);

        void Detelet(ProductDetail productDetail);
    }
}