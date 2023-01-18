using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;

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
