using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Interfaces;

namespace ApplicationLayer.Services
{
    public class ReturnService:IReturnService
    {
        public IEnumerable<ReturnDto> GetAllReturns()
        {
            throw new NotImplementedException();
        }

        public ReturnDto GetReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public ReturnDto AddNewReturn(CreateReturnDto newReturn)
        {
            throw new NotImplementedException();
        }

        public void DeleteReturnById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
