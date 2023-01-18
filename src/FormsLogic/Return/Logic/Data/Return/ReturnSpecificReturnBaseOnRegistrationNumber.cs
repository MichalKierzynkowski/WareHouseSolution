using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Interfaces;

namespace FormsLogic.Return.Logic.Data.Return
{
    public class ReturnSpecificReturnBaseOnRegistrationNumber
    {
        public IEnumerable<ReturnDto> Returns { get; set; }
        public int RegistrationNumber { get; }
        public ReturnDto Return { get; set; }
        public ReturnSpecificReturnBaseOnRegistrationNumber(IReturnService returnService, int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            Returns = returnService.GetAllReturns();
            Return = GetSpecificReturn();
        }
        private ReturnDto GetSpecificReturn()
        {
            return Returns.FirstOrDefault(x => x.Products.Any(p => p.RegistrationNumber == RegistrationNumber));
        }

    }
}
