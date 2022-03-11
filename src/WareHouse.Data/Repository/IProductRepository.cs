using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.SqlModels;

namespace WareHouse.Data.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(string productId);
    }
}
