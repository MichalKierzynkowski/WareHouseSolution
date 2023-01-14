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
           var wareHouse= _context.WareHouse.FirstOrDefault(x => x.Id == id);
           return wareHouse;
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

        public WareHouse GetByProductId(int productId)
        {
            return _context.WareHouse.FirstOrDefault(x => x.Products.Any(x => x.RegistrationNumber == productId));
        }

        public void UpdateQuantity(int quantity, WareHouse wareHouse)
        {

            var wareHouses = _context.WareHouse.FirstOrDefault(x => x.Id == wareHouse.Id);
            wareHouses.Quantity = wareHouses.Quantity - wareHouse.Quantity;
            _context.SaveChanges();
        }
    }
}