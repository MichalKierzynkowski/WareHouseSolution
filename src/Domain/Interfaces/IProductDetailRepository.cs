using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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