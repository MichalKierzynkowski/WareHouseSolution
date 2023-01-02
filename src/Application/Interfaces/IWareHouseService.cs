using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Dto.WareHouseDtos;

namespace ApplicationLayer.Interfaces
{
    public  interface IWareHouseService
    {
        IEnumerable<WareHouseDto> GetAllWareHouses();
        WareHouseDto AddNewWareHouse(CreateWareHouseDto newWareHouse);
       
    }
}