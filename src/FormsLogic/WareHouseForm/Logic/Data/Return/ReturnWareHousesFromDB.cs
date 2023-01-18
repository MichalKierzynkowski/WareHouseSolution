using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;

namespace FormsLogic.WareHouse.Logic.Data.Return
{
    public class ReturnWareHousesFromDB
    {
        public IEnumerable<WareHouseDto> WareHouses { get; set; }

        public ReturnWareHousesFromDB(IWareHouseService wareHouseService)
        {
            WareHouses = wareHouseService.GetAllWareHouses();
        }

    }
}