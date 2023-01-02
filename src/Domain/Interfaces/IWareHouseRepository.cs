using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IWareHouseRepository
    {
        IEnumerable<WareHouse> GetAll();

        WareHouse GetById(int id);

        WareHouse Add(WareHouse wareHouse);

        void Update(WareHouse wareHouse);

        void Delete(WareHouse wareHouse);
    }
}