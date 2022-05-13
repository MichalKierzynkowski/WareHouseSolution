using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
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
        private readonly WareHouseDbContext _context;

        public ProductRepository(WareHouseDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
           
            return _context.Products.ToList();
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
