using ApplicationLayer.Dto.Sale;

namespace ApplicationLayer.Interfaces
{
    public interface ISaleService
    {
        IEnumerable<SaleDto> GetAllSales();
        SaleDto AddNewSale(CreateSaleDto newSale);
    }
}
