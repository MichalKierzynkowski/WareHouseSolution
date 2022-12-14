using System.Data.Entity;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ReturnRepository:IReturnRepository
    {
        private readonly WareHouseDbContext _context;

        public ReturnRepository(WareHouseDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Return> GetAll()
        {
            return _context.Returns.Include(x => x.Products);
        }

        public Return GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Return Add(Return returnItem)
        {
            _context.Returns.Add(returnItem);
            _context.SaveChanges();
            return returnItem;
        }

        public void Update(Return returnItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(Return returnItem)
        {
            throw new NotImplementedException();
        }
    }
}
