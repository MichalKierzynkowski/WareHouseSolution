using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        private readonly WareHouseDbContext _context;

        public ProductDetailRepository(WareHouseDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductDetail> GetAll()
        {
            return _context.ProductDetail.ToList();
        }

        public ProductDetail GetById(int id)
        {
            return _context.ProductDetail.SingleOrDefault(x => x.Id == id);
        }

        public Product Add(ProductDetail productDetail)
        {
            throw new NotImplementedException();
        }

        public void Detelet(ProductDetail productDetail)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDetail productDetail)
        {
            throw new NotImplementedException();
        }
    }
}