using WareHouse.Data.SqlModels;

namespace WareHouse.Data.PurchaseRepository
{
    public interface IPurchaseRepository
    {
        void Insert(Purchase purchase);
    }
}
