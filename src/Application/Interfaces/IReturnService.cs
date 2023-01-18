using ApplicationLayer.Dto.ReturnDtos;

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