using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.SqlLiteConnectionSettings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISqlLiteDataAccess _sqlLiteDataAccess;
        public ProductRepository(ISqlLiteDataAccess sqlLiteDataAccess)
        {
            _sqlLiteDataAccess = sqlLiteDataAccess;
        }
        public IEnumerable<Product> GetAll()
        {

            throw new NotImplementedException();
        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
