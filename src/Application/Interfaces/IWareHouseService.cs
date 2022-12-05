using ApplicationLayer.Dto.WareHouse;

namespace ApplicationLayer.Interfaces
{
    public  interface IWareHouseService
    {
        IEnumerable<WareHouseDto> GetAllWareHouses();
        WareHouseDto GetWareHouseById(int id);
        WareHouseDto AddNewWareHouse(CreateWareHouseDto newWareHouse);
        void DeleteWareHouseById(int id);
    }
}
