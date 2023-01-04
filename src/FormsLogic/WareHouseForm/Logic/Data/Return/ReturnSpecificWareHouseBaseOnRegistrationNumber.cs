using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Interfaces;

namespace FormsLogic.WareHouseForm.Logic.Data.Return
{
    public  class ReturnSpecificWareHouseBaseOnRegistrationNumber
    {
        public IEnumerable<WareHouseDto> WareHouses { get; set; }
        public WareHouseDto WareHouse { get; set; }
        public int RegistrationNumber { get; set; }
        public ReturnSpecificWareHouseBaseOnRegistrationNumber(IWareHouseService wareHouseService,int registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            WareHouses = wareHouseService.GetAllWareHouses();
            WareHouse = GetSpecificWareHouse();
           
        }

        private WareHouseDto GetSpecificWareHouse()
        {
            return WareHouses.FirstOrDefault(x=>x.Products.Any(p=>p.RegistrationNumber==RegistrationNumber));
        }
    }
}
