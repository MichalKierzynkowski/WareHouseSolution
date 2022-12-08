using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Dto.WareHouse;

namespace ApplicationLayer.Interfaces
{
    public  interface IReturnService
    {
        IEnumerable<ReturnDto> GetAllReturns();
        ReturnDto GetReturnById(int id);
        ReturnDto AddNewReturn(CreateReturnDto newReturn);
        void DeleteReturnById(int id);
    }
}
