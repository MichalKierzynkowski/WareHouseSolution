using System.Data.Entity;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class SaleRepository:ISaleRepository
    {
        private readonly WareHouseDbContext _context;
        public SaleRepository(WareHouseDbContext context)
        {
            _context=context;
        }
        public IEnumerable<Sale> GetAll()
        {
            return _context.Sales;
        }

        public Sale GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Sale Add(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return sale;
        }

        public void Update(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
