using System.Data.Entity;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class WareHouseRepository:IWareHouseRepository
    {
        private readonly WareHouseDbContext _context;

        public WareHouseRepository(WareHouseDbContext context)
        {
            _context = context;
        }
        public IEnumerable<WareHouse> GetAll()
        {
            return _context.WareHouse.Include(x => x.Products);
        }

        public WareHouse GetById(int id)
        {
            throw new NotImplementedException();
        }
        public WareHouse Add(WareHouse wareHouse)
        {
            _context.WareHouse.Add(wareHouse);
            _context.SaveChanges();
            return wareHouse;
        }

        public void Update(WareHouse wareHouse)
        {
            throw new NotImplementedException();
        }

        public void Delete(WareHouse wareHouse)
        {
            throw new NotImplementedException();
        }
    }
}
