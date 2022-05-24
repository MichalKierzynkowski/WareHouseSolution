using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.SqlLiteConnectionSettings;
using Microsoft.EntityFrameworkCore;
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

        public IQueryable<Product> GetAll()
        {
            return _context.Products.Include(x => x.ProductDetail);
        }

        public Product GetById(int id)
        {
            return _context.Products.Include(x => x.ProductDetail).SingleOrDefault(x => x.Id == id);
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}