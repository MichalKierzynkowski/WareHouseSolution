using ApplicationLayer.Dto.WareHouse;

namespace ApplicationLayer.Interfaces
{
    public  interface IWareHouseService
    {
        IEnumerable<WareHouseDto> GetAllWareHouses();
        WareHouseDto AddNewWareHouse(CreateWareHouseDto newWareHouse);
       
    }
}