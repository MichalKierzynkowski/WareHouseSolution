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
        void Insert(Product product);
        void Update(Product product);
        void Delete(string productId);
        bool CheckExistenceOfBarNumber(decimal barNumber);
    }
}
