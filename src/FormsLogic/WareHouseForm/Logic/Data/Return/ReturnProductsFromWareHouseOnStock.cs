using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;
using System.Linq;
using FormsLogic.WareHouse.Logic.Data.Return;

namespace FormsLogic.WareHouseForm.Logic.Data.Return
{
    public class ReturnProductsFromWareHouseOnStock
    {
        public IEnumerable<WareHouseDto> WareHouses { get; set; }

        public ReturnProductsFromWareHouseOnStock(IWareHouseService wareHouseService)
        {
            WareHouses = ReturnWareHouseContainsOnlyProductsOnStock(wareHouseService.GetAllWareHouses());
        }

        public IEnumerable<WareHouseDto> ReturnWareHouseContainsOnlyProductsOnStock(IEnumerable<WareHouseDto> getAllWareHouses)
        {
            return getAllWareHouses.Where(x => x.Quantity > 0);
        }
    }
}
