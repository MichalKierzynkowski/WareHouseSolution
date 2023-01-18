using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Interfaces;

namespace FormsLogic.Return.Logic.Data.Return
{
    public class ReturnProductFromReturnOnStock
    {
        public IEnumerable<ReturnDto> Returns { get; set; }
        public ReturnProductFromReturnOnStock(IReturnService returnService)
        {

            Returns = ReturnReturnsContainsOnlyProductsOnStock(returnService.GetAllReturns());

        }

        private IEnumerable<ReturnDto>? ReturnReturnsContainsOnlyProductsOnStock(IEnumerable<ReturnDto> returns)
        {
            return returns.Where(x => x.Quantity > 0);
        }
    }
}
